using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Driving_School
{
    internal class InterClass
    {

        DBconnect connect = new DBconnect();

        public DataTable getInter_1()
        {
            MySqlCommand command = new MySqlCommand("SELECT nume, prenume, salariu FROM angajati A JOIN instructori I ON A.Angajat_ID = I.Angajat_ID WHERE I.Experienta = 'ridicata'", connect.getconnection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public DataTable getInter_2()
        {
            MySqlCommand command = new MySqlCommand("SELECT nume, prenume, numar_inmatriculare FROM (angajati A JOIN instructori I ON A.Angajat_ID = I.Angajat_ID) JOIN sedinte S ON S.Instructor_ID = I.Instructor_ID WHERE I.Experienta = 'ridicata' AND S.Progres = 'BUN' AND YEAR(S.Data) > 2023", connect.getconnection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public DataTable getInter_3()
        {
            MySqlCommand command = new MySqlCommand("SELECT nume, prenume, feedback_elev FROM elevi E JOIN prezente P ON E.Elev_ID = P.Elev_ID WHERE E.Nume = 'Popescu'", connect.getconnection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public DataTable getInter_4()
        {
            MySqlCommand command = new MySqlCommand("SELECT nume, prenume, numar_inmatriculare FROM (elevi E JOIN prezente P ON P.Elev_ID = E.Elev_ID) JOIN sedinte S ON S.Sedinta_ID = P.Sedinta_ID WHERE S.Progres = 'Multumit' AND P.Feedback_elev = 'Bun'", connect.getconnection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public DataTable getInter_5()
        {
            MySqlCommand command = new MySqlCommand("SELECT nume, prenume, AU.Numar_inmatriculare, Transmisie FROM ((angajati A JOIN instructori I ON A.Angajat_ID = I.Angajat_ID) JOIN sedinte S ON I.Instructor_ID = S.Instructor_ID) JOIN autovehicule AU ON AU.Numar_inmatriculare = S.Numar_inmatriculare WHERE AU.Marca = 'Skoda'", connect.getconnection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public DataTable getInter_6()
        {
            MySqlCommand command = new MySqlCommand("SELECT E.nume, E.prenume, AU.Numar_inmatriculare, Transmisie, A.nume, A.prenume FROM ((((angajati A JOIN instructori I ON A.Angajat_ID = I.Angajat_ID) JOIN sedinte S ON I.Instructor_ID = S.Instructor_ID) JOIN autovehicule AU ON AU.Numar_inmatriculare = S.Numar_inmatriculare) JOIN prezente P ON P.Sedinta_ID = S.Sedinta_ID) JOIN elevi E ON E.Elev_ID = P.Elev_ID WHERE AU.Categorie = 'B'", connect.getconnection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public DataTable getInter_7()
        {
            MySqlCommand command = new MySqlCommand("SELECT A.nume, A.prenume, A.Salariu FROM angajati A WHERE A.Angajat_ID NOT IN (SELECT Distinct A2.Angajat_ID FROM angajati A2 JOIN instructori I ON A2.Angajat_ID = I.Angajat_ID WHERE I.Experienta = 'ridicata')", connect.getconnection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public DataTable getInter_8()
        {
            MySqlCommand command = new MySqlCommand("SELECT A.Nume, A.Prenume, ( SELECT COUNT(S.Sedinta_ID) FROM sedinte S WHERE S.Instructor_ID = I.Instructor_ID ) AS NumarSedinte FROM angajati A JOIN instructori I ON A.Angajat_ID = I.Angajat_ID WHERE ( SELECT COUNT(S.Sedinta_ID) FROM sedinte S WHERE S.Instructor_ID = I.Instructor_ID ) > 1", connect.getconnection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public DataTable getInter_9()
        {
            MySqlCommand command = new MySqlCommand("SELECT I1.Experienta, A1.Nume, A1.Prenume, A1.Salariu FROM angajati A1 JOIN instructori I1 ON A1.Angajat_ID = I1.Angajat_ID WHERE (I1.Experienta, A1.Salariu) IN ( SELECT I2.Experienta, MAX(A2.Salariu) FROM angajati A2 JOIN instructori I2 ON A2.Angajat_ID = I2.Angajat_ID GROUP BY I2.Experienta )", connect.getconnection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public DataTable getInter_10()
        {
            MySqlCommand command = new MySqlCommand("SELECT A.Nume, A.Prenume FROM angajati A JOIN instructori I ON A.Angajat_ID = I.Angajat_ID WHERE I.Instructor_ID IN ( SELECT DISTINCT S.Instructor_ID FROM sedinte S WHERE MONTH(S.Data) = 1 AND YEAR(S.Data) = 2024 )", connect.getconnection);
            MySqlDataAdapter adapter = new MySqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

    }
}
