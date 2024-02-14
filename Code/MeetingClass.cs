using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Driving_School
{
    internal class MeetingClass
    {
        DBconnect connect = new DBconnect();
        //create a function to insert course
        public bool insetMeeting(string type, int instid, string numin, DateTime date, int hr, string prog, string location)
        {
            MySqlCommand command = new MySqlCommand("INSERT INTO `sedinte`(`Instructor_ID`, `Numar_inmatriculare`, `Tip_sedinta`, `Data`, `Ora`, `Progres`, `Locatie`) VALUES (@ii, @ni, @ty, @da, @hr, @pr, @lo)", connect.getconnection);

            command.Parameters.Add("@ii", MySqlDbType.Int32).Value = instid;
            command.Parameters.Add("@ni", MySqlDbType.VarChar).Value = numin;
            command.Parameters.Add("@ty", MySqlDbType.VarChar).Value = type;
            command.Parameters.Add("@da", MySqlDbType.DateTime).Value = date;
            command.Parameters.Add("@hr", MySqlDbType.Int32).Value = hr;
            command.Parameters.Add("@pr", MySqlDbType.VarChar).Value = prog;
            command.Parameters.Add("@lo", MySqlDbType.VarChar).Value = location;
            connect.openConnect();
            if (command.ExecuteNonQuery() == 1)
            {
                connect.closeConnect();
                return true;
            }
            else
            {
                connect.closeConnect();
                return false;
            }
        }

        //create a function to get course list
        public DataTable getMeeting(MySqlCommand command)
        {
            command.Connection = connect.getconnection;
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public DataTable getInst(MySqlCommand command)
        {
            command.Connection = connect.getconnection;
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public DataTable getAuto(MySqlCommand command)
        {
            command.Connection = connect.getconnection;
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        //create a update function for course edit
        public bool updateMeeting(int id, int idinst, string numin, string type, DateTime date, int hr, string prog, string location)
        {
            MySqlCommand command = new MySqlCommand("UPDATE `sedinte` SET 'Instructor'=@ii,'Numar_inmatriculare'=@ni,`Tip_sedinta`=@ty,`Data`=@da,`Ora`=@hr,`Progres`=@pr,`Locatie`=@lo WHERE 'Sedinta_ID'=@id", connect.getconnection);


            command.Parameters.Add("@ii", MySqlDbType.Int32).Value = idinst;
            command.Parameters.Add("@ni", MySqlDbType.VarChar).Value = numin;
            command.Parameters.Add("@id", MySqlDbType.Int32).Value = id;
            command.Parameters.Add("@ty", MySqlDbType.VarChar).Value = type;
            command.Parameters.Add("@da", MySqlDbType.DateTime).Value = date;
            command.Parameters.Add("@hr", MySqlDbType.Int32).Value = hr;
            command.Parameters.Add("@pr", MySqlDbType.VarChar).Value = prog;
            command.Parameters.Add("@lo", MySqlDbType.VarChar).Value = location;
            connect.openConnect();
            if (command.ExecuteNonQuery() == 1)
            {
                connect.closeConnect();
                return true;
            }
            else
            {
                connect.closeConnect();
                return false;
            }
        }
        //Create a function to delete a course
        //we only need course id
        public bool deleteMeeting(int id)
        {
            MySqlCommand command = new MySqlCommand("DELETE FROM `sedinte` WHERE `Sedinta_ID`=@id", connect.getconnection);
            command.Parameters.Add("@id", MySqlDbType.Int32).Value = id;
            connect.openConnect();
            if (command.ExecuteNonQuery() == 1)
            {
                connect.closeConnect();
                return true;
            }
            else
            {
                connect.closeConnect();
                return false;
            }
        }

        public DataTable searchMeeting(string searchdata)
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM `sedinte` WHERE CONCAT(`Tip_sedinta`) LIKE '%" + searchdata + "%'", connect.getconnection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
    }
}

