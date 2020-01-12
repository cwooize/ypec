using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;

namespace WindowsFormsApp1.Controller
{
    class Query
    {
        OleDbConnection     connection;
        OleDbCommand        command;
        OleDbDataAdapter    dataAdapter;
        DataTable           bufferTable;
        public Query(string Conn)
        {
            connection = new OleDbConnection(Conn);
            bufferTable = new DataTable();
        }
        public DataTable UpdateКлассы()
        {
            connection.Open();
            dataAdapter = new OleDbDataAdapter("SELECT * FROM Классы", connection);
            bufferTable.Clear();
            dataAdapter.Fill(bufferTable);
            connection.Close();
            return bufferTable;
        }
        public DataTable UpdateНаграды()
        {
            connection.Open();
            dataAdapter = new OleDbDataAdapter("SELECT Код_награды FROM Награды", connection);
            bufferTable.Clear();
            dataAdapter.Fill(bufferTable);
            connection.Close();
            return bufferTable;
        }
        public DataTable UpdateДостижения()
        {
            connection.Open();
            dataAdapter = new OleDbDataAdapter("SELECT Код_достижения FROM Достижения_обучающихся", connection);
            bufferTable.Clear();
            dataAdapter.Fill(bufferTable);
            connection.Close();
            return bufferTable;
        }
        public DataTable UpdateКС()
        {
            connection.Open();
            dataAdapter = new OleDbDataAdapter("SELECT Код_КС FROM Список_кружков_секций", connection);
            bufferTable.Clear();
            dataAdapter.Fill(bufferTable);
            connection.Close();
            return bufferTable;
        }
        public DataTable UpdateМероприятия()
        {
            connection.Open();
            dataAdapter = new OleDbDataAdapter("SELECT Код_мероприятия FROM Список_мероприятий", connection);
            bufferTable.Clear();
            dataAdapter.Fill(bufferTable);
            connection.Close();
            return bufferTable;
        }
        public DataTable UpdateРезультаты()
        {
            connection.Open();
            dataAdapter = new OleDbDataAdapter("SELECT * FROM Список_мероприятий", connection);
            bufferTable.Clear();
            dataAdapter.Fill(bufferTable);
            connection.Close();
            return bufferTable;
        }
        public void Addclass(string Код_класса, string Классный_руководитель)
        {
            connection.Open();
            command = new OleDbCommand($"INSERT INTO Классы(Код_класса, Классный_руководитель) VALUES(@Код_класса, @Классный_руководитель)", connection);
            command.Parameters.AddWithValue("Код_класса", Код_класса);
            command.Parameters.AddWithValue("Классный_руководитель", Классный_руководитель);
            command.ExecuteNonQuery();
            connection.Close();
        }
        public void AddLearners(string Код_обучающегося, string Код_класса, string Фамилия, string Имя, string Отчество, string Пол, string Дата_рождения)
        {
            connection.Open();
            command = new OleDbCommand($"INSERT INTO Список_обучающихся(Код_обучающегося, Код_класса, Фамилия, Имя, Отчество, Пол, Дата_рождения) VALUES(@Код_обучающегося, @Код_класса, @Фамилия, @Имя, @Отчество, @Пол, @Дата_рождения)", connection);
            command.Parameters.AddWithValue("Код_обучающегося", Код_обучающегося);
            command.Parameters.AddWithValue("Код_класса", Код_класса);
            command.Parameters.AddWithValue("Фамилия", Фамилия);
            command.Parameters.AddWithValue("Имя", Имя);
            command.Parameters.AddWithValue("Отчество", Отчество);
            command.Parameters.AddWithValue("Пол", Пол);
            command.Parameters.AddWithValue("Дата_рождения", Дата_рождения);
            command.ExecuteNonQuery();
            connection.Close();
        }
        public void AddReward(string Код_награды, string Код_обучающегося, string Наименование, string Место, string Дата_получения, string Примечание)
        {
            connection.Open();
            command = new OleDbCommand($"INSERT INTO Награды(Код_награды, Код_обучающегося, Наименование, Место, Дата_получения, Примечание) VALUES(@Код_награды, @Код_обучающегося, @Наименование, @Место, @Дата_получения, @Примечание)", connection);
            command.Parameters.AddWithValue("Код_награды", Код_награды);
            command.Parameters.AddWithValue("Код_обучающегося", Код_обучающегося);
            command.Parameters.AddWithValue("Наименование", Наименование);
            command.Parameters.AddWithValue("Место", Место);
            command.Parameters.AddWithValue("Дата_получения", Дата_получения);
            command.Parameters.AddWithValue("Примечание", Примечание);
            command.ExecuteNonQuery();
            connection.Close();
        }
        public void AddAch(string Код_достижения, string Код_обучающегося, string Наименование, string Дата_получения, string Примечание)
        {
            connection.Open();
            command = new OleDbCommand($"INSERT INTO Достижения_обучающихся(Код_достижения, Код_обучающегося, Наименование, Дата_получения, Примечание) VALUES(@Код_достижения, @Код_обучающегося, @Наименование, @Дата_получения, @Примечание)", connection);
            command.Parameters.AddWithValue("Код_достижения", Код_достижения);
            command.Parameters.AddWithValue("Код_обучающегося", Код_обучающегося);
            command.Parameters.AddWithValue("Наименование", Наименование);
            command.Parameters.AddWithValue("Дата_получения", Дата_получения);
            command.Parameters.AddWithValue("Примечание", Примечание);
            command.ExecuteNonQuery();
            connection.Close();
        }
        public void AddEvents(string Код_мероприятия, string Тип_мероприятия, string Наименование, string Дата_проведения, string Примечание)
        {
            connection.Open();
            command = new OleDbCommand($"INSERT INTO Список_мероприятий(Код_мероприятия, Тип_мероприятия, Наименование, Дата_проведения, Примечание) VALUES(@Код_мероприятия, @Тип_мероприятия, @Наименование, @Дата_проведения, @Примечание)", connection);
            command.Parameters.AddWithValue("Код_мероприятия", Код_мероприятия);
            command.Parameters.AddWithValue("Тип_мероприятия", Тип_мероприятия);
            command.Parameters.AddWithValue("Наименование", Наименование);
            command.Parameters.AddWithValue("Дата_проведения", Дата_проведения);
            command.Parameters.AddWithValue("Примечание", Примечание);
            command.ExecuteNonQuery();
            connection.Close();
        }
        public void AddResult(string Код_мероприятия, string место1, string место2, string место3)
        {
            connection.Open();
            command = new OleDbCommand($"INSERT INTO Результаты_мероприятий(Код_мероприятия, [1 место], [2 место], [3 место]) VALUES(@Код_мероприятия, @место1, @место2, @место3)", connection);
            command.Parameters.AddWithValue("Код_мероприятия", Код_мероприятия);
            command.Parameters.AddWithValue("[1 место]", место1);
            command.Parameters.AddWithValue("[2 место]", место2);
            command.Parameters.AddWithValue("[3 место]", место3);
            command.ExecuteNonQuery();
            connection.Close();
        }
        public void AddClub(string Код_КС, string Наименование, string НаправлениеДеятельности, string Руководитель, string ДниНедели, string Время)
        {
            connection.Open();
            command = new OleDbCommand($"INSERT INTO Список_кружков_секций(Код_КС, Наименование, [Направление деятельности], Руководитель, [Дни недели], Время) VALUES(@Код_КС, @Наименование, @НаправлениеДеятельности, @Руководитель, @ДниНедели, @Время)", connection);
            command.Parameters.AddWithValue("Код_КС", Код_КС);
            command.Parameters.AddWithValue("Наименование", Наименование);
            command.Parameters.AddWithValue("[Направление деятельности]", НаправлениеДеятельности);
            command.Parameters.AddWithValue("Руководитель", Руководитель);
            command.Parameters.AddWithValue("[Дни недели]", ДниНедели);
            command.Parameters.AddWithValue("Время", Время);
            command.ExecuteNonQuery();
            connection.Close();
        }
    }
}
