﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using GameServer.Model;

namespace GameServer.DAO
{
    class ResultDAO
    {
        public Result GetResultByUserId(MySqlConnection conn,int userId)
        {
            MySqlDataReader reader = null;
            try
            {
                MySqlCommand cmd = new MySqlCommand("select * from result where userid = @userid", conn);
                cmd.Parameters.AddWithValue("userid", userId);
                reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    int id = reader.GetInt32("id");
                    int totalCount = reader.GetInt32("totalcount");
                    int winCount = reader.GetInt32("wincount");
                    Result result = new Result(id, userId, totalCount, winCount);
                    return result;
                }
                else
                {
                    Result result = new Result(-1, userId, 0, 0);
                    return result;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("在GetResultByUserId时出现异常:" + e);
            }
            finally
            {
                if (reader != null)
                {
                    reader.Close();
                }
            }

            return null;
        }

        public void UpdateOrAddResult(MySqlConnection conn,Result result)
        {
            try
            {
                MySqlCommand cmd = null;
                
                if (result.Id <= -1)
                {
                    cmd =
                        new MySqlCommand(
                            "insert into result set totalcount=@totalcount,wincount=@wincount,userid = @userid", conn);
                }
                else
                {
                    cmd =
                       new MySqlCommand(
                            "update result set totalcount=@totalcount,wincount = @wincount where userid = @userid", conn);
                }

                cmd.Parameters.AddWithValue("totalcount", result.TotalCount);
                cmd.Parameters.AddWithValue("wincount", result.WinCount);
                cmd.Parameters.AddWithValue("userid", result.UserId);
                cmd.ExecuteNonQuery();
                if (result.Id <= -1)
                {
                    Result tempResult = GetResultByUserId(conn, result.UserId);
                    result.Id = tempResult.Id;
                }
            }
            catch(Exception e)
            {
                Console.WriteLine("在UpdateOrAddResult时出现异常:" + e);
            }

        }
    }
}
