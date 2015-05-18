//This class for perform all database CRUID operations 

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Chinski_Zodiak.Model;
using SQLite;

public class ZnakDao
{
    SQLiteConnection dbConn;
    string DB_PATH = Path.Combine(Windows.Storage.ApplicationData.Current.LocalFolder.Path, "db.sqlite");


    public async Task<bool> onCreate(string DB_PATH)
    {
        try
        {
            if (!CheckFileExists(DB_PATH).Result)
            {
                using (dbConn = new SQLiteConnection(DB_PATH))
                {
                    dbConn.CreateTable<Znak>();
                }
            }
            return true;
        }
        catch
        {
            return false;
        }
    }
    private async Task<bool> CheckFileExists(string fileName)
    {
        try
        {
            var store = await Windows.Storage.ApplicationData.Current.LocalFolder.GetFileAsync(fileName);
            return true;
        }
        catch
        {
            return false;
        }
    }
    // Retrieve the all contact list from the database. 
    public ObservableCollection<Znak> WczytajZnaki()
    {
        using (var dbConn = new SQLiteConnection(DB_PATH))
        {
            List<Znak> myCollection = dbConn.Table<Znak>().ToList<Znak>();
            ObservableCollection<Znak> znaki = new ObservableCollection<Znak>(myCollection);
            return znaki;
        }
    }

    public bool CzyZnakIstnieje(String name)
    {
        using (var dbConn = new SQLiteConnection(DB_PATH))
        {
            List<Znak> myCollection = dbConn.Table<Znak>().ToList<Znak>();

            foreach (Znak znak in myCollection)
            {
                if (znak.Nazwa.Equals(name))
                {
                    return true;
                }
            }

            return false;
        }
    }

    public String WezOpis(String name)
    {
        using (var dbConn = new SQLiteConnection(DB_PATH))
        {
            List<Znak> myCollection = dbConn.Table<Znak>().ToList<Znak>();

            foreach (Znak znak in myCollection)
            {
                if (znak.Nazwa.Equals(name))
                {
                    return znak.Opis;
                }
            }

            return "brak";
        }
    }

    public void WstawZnak(Znak znak)
    {
        using (var dbConn = new SQLiteConnection(DB_PATH))
        {
            dbConn.RunInTransaction(() =>
            {
                dbConn.Insert(znak);
            });
        }
    }
}