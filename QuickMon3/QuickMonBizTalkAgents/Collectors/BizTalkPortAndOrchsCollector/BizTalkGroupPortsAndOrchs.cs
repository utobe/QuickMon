﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using QuickMon.BizTalk;

namespace QuickMon.Collectors
{
    public class BizTalkGroupPortsAndOrchs : BizTalkGroupBase
    {
        private int processBatchSize = 20;

        public BizTalkGroupPortsAndOrchs()
        {
            ReceiveLocations = new List<string>();
            SendPorts = new List<string>();
            Orchestrations = new List<string>();
        }

        #region Properties
        public List<string> ReceiveLocations { get; set; }
        public List<string> SendPorts { get; set; }
        public List<string> Orchestrations { get; set; }
        public bool AllReceiveLocations { get; set; }
        public bool AllSendPorts { get; set; }
        public bool AllOrchestrations { get; set; }
        #endregion

        #region Receive locations
        internal int GetTotalReceiveLocationCount()
        {
            int totalCount = -1;
            string sql = "select count(*) from dbo.adm_ReceiveLocation with (Readpast)";
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                using (SqlCommand cmnd = new SqlCommand(sql, conn))
                {
                    cmnd.CommandType = CommandType.Text;
                    object tmp = cmnd.ExecuteScalar();
                    if (tmp != null)
                        totalCount = (int)tmp;
                }
            }
            return totalCount;
        }
        internal int GetDisabledReceiveLocationCount(List<string> receiveLocationNames)
        {
            int disabledCount = -1;
            string sql = "select sum(case [Disabled] when 0 then 0 else 1 end) as [Disabled] from dbo.adm_ReceiveLocation with (Readpast)";
            if (receiveLocationNames != null && receiveLocationNames.Count > 0)
            {
                //if the list of receive locations are too big it can cause the sql string to become too long
                if (receiveLocationNames.Count > processBatchSize)
                {
                    List<string> smallList = new List<string>();
                    List<string> restList = new List<string>();
                    smallList.AddRange(receiveLocationNames.Take(processBatchSize).ToArray());
                    restList.AddRange(receiveLocationNames.Skip(processBatchSize).ToArray());
                    disabledCount = GetDisabledReceiveLocationCount(smallList);
                    if (disabledCount > -1)
                        disabledCount = disabledCount + GetDisabledReceiveLocationCount(restList);
                    return disabledCount;
                }
                else
                {
                    sql += " where [Name] in (";
                    foreach (string recLoc in receiveLocationNames)
                    {
                        sql += "'" + recLoc.Replace("'", "''") + "',";
                    }
                    sql = sql.TrimEnd(',');
                    sql += ")";
                }
            }
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                using (SqlCommand cmnd = new SqlCommand(sql, conn))
                {
                    cmnd.CommandType = CommandType.Text;
                    object tmp = cmnd.ExecuteScalar();
                    if (tmp != null)
                        disabledCount = (int)tmp;
                }
            }
            return disabledCount;
        }
        internal List<ReceiveLocationInfo> GetReceiveLocationList()
        {
            List<ReceiveLocationInfo> list = new List<ReceiveLocationInfo>();
            string sql = "select p.nvcName as [Receive Port], l.[Name] as [Receive location] ,h.Name as [Host], l.[Disabled] " +
                "from dbo.adm_ReceiveLocation l with (Readpast) inner join dbo.bts_receiveport p with (Readpast) on " +
                "l.ReceivePortId = p.nID inner join dbo.adm_ReceiveHandler rh with (Readpast) on " +
                "l.ReceiveHandlerId = rh.Id inner join dbo.adm_Host h with (Readpast) on " +
                "rh.HostId = h.Id " +
                "order by p.nvcName, l.[Name]";
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                using (SqlCommand cmnd = new SqlCommand(sql, conn))
                {
                    cmnd.CommandType = CommandType.Text;
                    using (SqlDataReader r = cmnd.ExecuteReader())
                    {
                        while (r.Read())
                        {
                            ReceiveLocationInfo receiveLocationInfo = new ReceiveLocationInfo()
                            {
                                ReceivePortName = r["Receive Port"].ToString(),
                                ReceiveLocationName = r["Receive location"].ToString(),
                                HostName = r["Host"].ToString(),
                                Disabled = r["Disabled"].ToString() != "0"
                            };
                            list.Add(receiveLocationInfo);
                        }
                    }
                }
            }
            return list;
        }
        internal List<string> GetDisabledReceiveLocationNames()
        {
            List<string> list = new List<string>();
            string sql = "select p.nvcName as [Receive Port], l.[Name] as [Receive location] " +
                "from dbo.adm_ReceiveLocation l with (Readpast) inner join dbo.bts_receiveport p with (Readpast) on " +
                "l.ReceivePortId = p.nID " +
                "where not (l.[Disabled] = 0) " +
                "order by p.nvcName, l.[Name]";
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                using (SqlCommand cmnd = new SqlCommand(sql, conn))
                {
                    cmnd.CommandType = CommandType.Text;
                    using (SqlDataReader r = cmnd.ExecuteReader())
                    {
                        while (r.Read())
                        {
                            list.Add(r["Receive Port"].ToString() + " - " + r["Receive location"].ToString());
                        }
                    }
                }
            }
            return list;
        }
        #endregion

        #region Send ports
        internal int GetTotalSendPortCount()
        {
            int totalCount = -1;
            string sql = "select count(*) from dbo.bts_sendport with (Readpast)";
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                using (SqlCommand cmnd = new SqlCommand(sql, conn))
                {
                    cmnd.CommandType = CommandType.Text;
                    object tmp = cmnd.ExecuteScalar();
                    if (tmp != null)
                        totalCount = (int)tmp;
                }
            }
            return totalCount;
        }
        internal int GetStoppedSendPortCount(List<string> sendPortNames)
        {
            int stoppedCount = -1;
            string sql = "select count(*) from dbo.bts_sendport with (Readpast) where nPortStatus = 2";
            if (sendPortNames != null && sendPortNames.Count > 0)
            {
                //if the list of send ports are too big it can cause the sql string to become too long
                if (sendPortNames.Count > processBatchSize)
                {
                    List<string> smallList = new List<string>();
                    List<string> restList = new List<string>();
                    smallList.AddRange(sendPortNames.Take(processBatchSize).ToArray());
                    restList.AddRange(sendPortNames.Skip(processBatchSize).ToArray());
                    stoppedCount = GetStoppedSendPortCount(smallList);
                    if (stoppedCount > -1)
                        stoppedCount = stoppedCount + GetStoppedSendPortCount(restList);
                    return stoppedCount;
                }
                else
                {
                    sql += " and [nvcName] in (";
                    foreach (string sendPortName in sendPortNames)
                    {
                        sql += "'" + sendPortName.Replace("'", "''") + "',";
                    }
                    sql = sql.TrimEnd(',');
                    sql += ")";
                }
            }
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                using (SqlCommand cmnd = new SqlCommand(sql, conn))
                {
                    cmnd.CommandType = CommandType.Text;
                    object tmp = cmnd.ExecuteScalar();
                    if (tmp != null)
                        stoppedCount = (int)tmp;
                }
            }
            return stoppedCount;
        }
        internal List<SendPortInfo> GetSendPortList()
        {
            List<SendPortInfo> list = new List<SendPortInfo>();
            string sql = "select nvcName, nPortStatus as [Send Port Name] from dbo.bts_sendport with (Readpast) order by	nvcName";
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                using (SqlCommand cmnd = new SqlCommand(sql, conn))
                {
                    cmnd.CommandType = CommandType.Text;
                    using (SqlDataReader r = cmnd.ExecuteReader())
                    {

                        while (r.Read())
                        {
                            list.Add(new SendPortInfo()
                            {
                                Name = r[0].ToString(),
                                State = ((int)r[1]) == 3 ? "Started" : ((int)r[1]) == 2 ? "Stopped" : "Unenlisted"
                            });
                        }
                    }
                }
            }
            return list;
        }
        internal List<string> GetStoppedSendPortNames()
        {
            List<string> list = new List<string>();
            string sql = "select nvcName from dbo.bts_sendport with (Readpast) where nPortStatus = 2 order by nvcName";
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                using (SqlCommand cmnd = new SqlCommand(sql, conn))
                {
                    cmnd.CommandType = CommandType.Text;
                    using (SqlDataReader r = cmnd.ExecuteReader())
                    {
                        while (r.Read())
                        {
                            list.Add(r[0].ToString());
                        }
                    }
                }
            }
            return list;
        }
        #endregion

        #region Orchestrations
        public int GetTotalOrchestrationCount()
        {
            int totalCount = -1;
            string sql = "select count(*) from dbo.bts_orchestration with (Readpast)";
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                using (SqlCommand cmnd = new SqlCommand(sql, conn))
                {
                    cmnd.CommandType = CommandType.Text;
                    object tmp = cmnd.ExecuteScalar();
                    if (tmp != null)
                        totalCount = (int)tmp;
                }
            }
            return totalCount;
        }
        public int GetStoppedOrchestrationCount(List<string> orchestrationNames)
        {
            int stoppedCount = -1;
            string sql = "select count(*) from dbo.bts_orchestration with (Readpast) where nOrchestrationStatus = 2";
            if (orchestrationNames != null && orchestrationNames.Count > 0)
            {
                //if the list of orchestrations are too big it can cause the sql string to become too long
                if (orchestrationNames.Count > processBatchSize)
                {
                    List<string> smallList = new List<string>();
                    List<string> restList = new List<string>();
                    smallList.AddRange(orchestrationNames.Take(processBatchSize).ToArray());
                    restList.AddRange(orchestrationNames.Skip(processBatchSize).ToArray());
                    stoppedCount = GetStoppedOrchestrationCount(smallList);
                    if (stoppedCount > -1)
                        stoppedCount = stoppedCount + GetStoppedOrchestrationCount(restList);
                    return stoppedCount;
                }
                else
                {
                    sql += " and [nvcFullName] in (";
                    foreach (string orchestrationName in orchestrationNames)
                    {
                        sql += "'" + orchestrationName.Replace("'", "''") + "',";
                    }
                    sql = sql.TrimEnd(',');
                    sql += ")";
                }
            }
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                using (SqlCommand cmnd = new SqlCommand(sql, conn))
                {
                    cmnd.CommandType = CommandType.Text;
                    object tmp = cmnd.ExecuteScalar();
                    if (tmp != null)
                        stoppedCount = (int)tmp;
                }
            }
            return stoppedCount;
        }
        public List<SendPortInfo> GetOrchestrationList()
        {
            List<SendPortInfo> list = new List<SendPortInfo>();
            string sql = "select nvcFullName, nOrchestrationStatus from dbo.bts_orchestration with (Readpast) order by nvcFullName";
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                using (SqlCommand cmnd = new SqlCommand(sql, conn))
                {
                    cmnd.CommandType = CommandType.Text;
                    using (SqlDataReader r = cmnd.ExecuteReader())
                    {
                        while (r.Read())
                        {
                            list.Add(new SendPortInfo()
                            {
                                Name = r[0].ToString(),
                                State = ((int)r[1]) == 3 ? "Started" : ((int)r[1]) == 2 ? "Stopped" : "Unenlisted"
                            });
                        }
                    }
                }
            }
            return list;
        }
        internal List<string> GetStoppedOrchestrationNames()
        {
            List<string> list = new List<string>();
            string sql = "select nvcFullName from dbo.bts_orchestration with (Readpast) where nOrchestrationStatus = 2 order by nvcFullName";
            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                using (SqlCommand cmnd = new SqlCommand(sql, conn))
                {
                    cmnd.CommandType = CommandType.Text;
                    using (SqlDataReader r = cmnd.ExecuteReader())
                    {
                        while (r.Read())
                        {
                            list.Add(r[0].ToString());
                        }
                    }
                }
            }
            return list;
        }
        #endregion


    }
}
