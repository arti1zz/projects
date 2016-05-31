using System;
using System.Windows.Forms;
using System.Threading;
using System.Data.OleDb;
using System.IO;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        private actions act = new actions();                                    //all the actions has another class(not graphics actions)
        private Thread[] simLine = new Thread[16];                              //the threads
        private int i = 0;                                                      //current action of loop
        private OleDbConnection connection = new OleDbConnection();             //connection to mdb
        private object baton = new object();                                    //for synchronisation of threads
        private bool STOP = false;                                              //should program stop the work
        private int currThread;                                                 //current thread number
        private string path = Directory.GetCurrentDirectory()+@"\Database1.accdb";

        public Form1()
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source='"+path+"'; Persist Security Info=False;";
        }

        private void Step1_Click(object sender, EventArgs e)
        {
            STOP = false;
            if (act.check(ThreadsNum.Text))                                 //is the number between 2 and 15?
            {
                Error1.Visible = false;
                CheckForIllegalCrossThreadCalls = false;
                for (i=0; i < int.Parse(ThreadsNum.Text);i++)               //threads start the work
                {
                    currThread = i;
                    simLine[i] = new Thread(steps);
                    simLine[i].Name = (i + 1).ToString();
                    simLine[i].Start();
                    Thread.Sleep(15);
                }
            }
            else Error1.Visible = true;
        }
        /// <summary>
        /// generating strings, making sure table is in the correct form and adding data in the table
        /// </summary>
        private void steps()
        {
            int sleep_time = new Random().Next(500, 2000);
            Thread.Sleep(sleep_time);                               //random sleep (0,5-2s)
            if (!STOP)
            {
                string save = act.ranString();                                                          //random string
                ListViewItem this_one = new ListViewItem((Thread.CurrentThread.Name));
                this_one.SubItems.Add(save);
                ThreadList.Items.Add(this_one);                                                         //adding to table random string
                if (ThreadList.Items.Count > 20)                                                        
                    lock (baton)                                                                        //synchronisation
                    {
                        ThreadList.Items[0].Remove();
                    }
                update_table(save, int.Parse(Thread.CurrentThread.Name), sleep_time);
                Thread.Sleep(50);
            }
        }
        /// <summary>
        /// Updating the DB
        /// </summary>
        /// <param name="data"></param>
        /// <param name="id"></param>
        /// <param name="time"></param>
        private void update_table(string data, int id, int time)  
        {
            lock (baton)                                                        //for threads synchronisation
            {
                try
                {
                    connection.Open();                                          //opening connection
                    OleDbCommand command = new OleDbCommand();
                    command.Connection = connection;
                    //request
                    command.CommandText = "insert into Threads (ThreadID,ThreadTime,Data) values('" + id + "','" + time + "','" + data + "')";
                    command.ExecuteNonQuery();
                    connection.Close();                                         //end of connection
                }
                catch (Exception ex) { MessageBox.Show("Error" + ex); }         //error message(if something wents wrong
            }

        }
        /// <summary>
        /// Stop button actions
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            STOP = true;
        }
    }
}
