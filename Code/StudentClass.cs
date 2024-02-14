﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Driving_School
{
    internal class StudentClass
    {
        DBconnect connect = new DBconnect();

        public bool insertStudent(string fname, string lname, string CNP, string address, string phone)
        {
            MySqlCommand command = new MySqlCommand("INSERT INTO `elevi`(`Nume`, `Prenume`, `CNP`, `Adresa`, `Numar_telefon`) VALUES(@fn, @ln, @cnp, @adr, @ph)",connect.getconnection);
            command.Parameters.Add("@fn", MySqlDbType.VarChar).Value = fname;
            command.Parameters.Add("@ln", MySqlDbType.VarChar).Value = lname;
            command.Parameters.Add("@cnp", MySqlDbType.VarChar).Value = CNP;
            command.Parameters.Add("@adr", MySqlDbType.VarChar).Value = address;
            command.Parameters.Add("@ph", MySqlDbType.VarChar).Value = phone;

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
        public DataTable getStudentlist(MySqlCommand command)
        {
            command.Connection = connect.getconnection;
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        // Create a function to execute the count query(total)
        public string exeCount(string query)
        {
            MySqlCommand command = new MySqlCommand(query, connect.getconnection);
            connect.openConnect();
            string count = command.ExecuteScalar().ToString();
            connect.closeConnect();
            return count;
        }
        //to get the total student
        public string totalStudent()
        {
            return exeCount("SELECT COUNT(*) FROM elevi");
        }

        //create a function search for student (first name, last name, address)
        public DataTable searchStudent(string searchdata)
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM `elevi` WHERE CONCAT(`Nume`,`Prenume`,`Adresa`) LIKE '%" + searchdata + "%'", connect.getconnection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        //create a function edit for student
        public bool updateStudent(int id, string fname, string lname, string CNP, string address, string phone)
        {
            MySqlCommand command = new MySqlCommand("UPDATE `elevi` SET `Nume`=@fn,`Prenume`=@ln,`CNP`=@cnp,`Adresa`=@adr,`Numar_Telefon`=@ph WHERE `Elev_ID`= @id", connect.getconnection);

            //@id,@fn, @ln, @bd, @gd, @ph, @adr, @img
            command.Parameters.Add("@id", MySqlDbType.Int32).Value = id;
            command.Parameters.Add("@fn", MySqlDbType.VarChar).Value = fname;
            command.Parameters.Add("@ln", MySqlDbType.VarChar).Value = lname;
            command.Parameters.Add("@cnp", MySqlDbType.VarChar).Value = CNP;
            command.Parameters.Add("@adr", MySqlDbType.VarChar).Value = address;
            command.Parameters.Add("@ph", MySqlDbType.VarChar).Value = phone;
            

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
        public bool deleteStudent(int id)
        {
            MySqlCommand command = new MySqlCommand("DELETE FROM `elevi` WHERE `Elev_ID`=@id", connect.getconnection);

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

