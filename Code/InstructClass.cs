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
    internal class InstructClass
    {
        DBconnect connect = new DBconnect();

        public bool insertInstruct(int id, string experienta, string categorie)
        {
            MySqlCommand command = new MySqlCommand("INSERT INTO `instructori`(`Angajat_ID`, `Experienta`, `Categorie`) VALUES(@aid, @exp, @cat)", connect.getconnection);
            command.Parameters.Add("@id", MySqlDbType.Int32).Value = id;
            command.Parameters.Add("@exp", MySqlDbType.VarChar).Value = experienta;
            command.Parameters.Add("@cat", MySqlDbType.VarChar).Value = categorie;

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
        // to get student table
        public DataTable getInstructlist(MySqlCommand command)
        {
            command.Connection = connect.getconnection;
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        
        //create a function search for student (first name, last name, address)
        public DataTable searchInstruct(string searchdata)
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM `instructori` WHERE CONCAT(`Angajat_ID`,`Experienta`,`Categorie`) LIKE '%" + searchdata + "%'", connect.getconnection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        //create a function edit for student
        public bool updateInstruct(int id, int aid, string experienta, string categorie)
        {
            MySqlCommand command = new MySqlCommand("UPDATE `instructori` SET `Angajat_ID`=@aid,`Experienta`=@exp,`Categorie`=@cat WHERE `Instructor_ID`= @id", connect.getconnection);
            command.Parameters.Add("@id", MySqlDbType.Int32).Value = id;
            command.Parameters.Add("@aid", MySqlDbType.Int32).Value = aid;
            command.Parameters.Add("@exp", MySqlDbType.VarChar).Value = experienta;
            command.Parameters.Add("@cat", MySqlDbType.VarChar).Value = categorie;


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
        //Create a function to delete data
        //we need only id 
        public bool deleteInstruct(int id)
        {
            MySqlCommand command = new MySqlCommand("DELETE FROM `instructori` WHERE `Instructor_ID`=@id", connect.getconnection);

            //@id
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
        // create a function for any command in studentDb
        public DataTable getList(MySqlCommand command)
        {
            command.Connection = connect.getconnection;
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
    }
}

