using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace linqprogram2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
//****************************************************************************************program 1
            //The  Three parts of a linq query :
            // 1. data source
            int[] numbers = new int[7] { 0, 1, 2, 3, 4, 5, 6 };
            //2. query creation.
            //num query is an IEnumerable<int>
            IEnumerable<int> numQuery1 =
            from num in numbers
            where num % 2 == 0
            orderby num descending
            select num;
            //3. query execution;
            foreach (int num in numQuery1)
            {
                Console.Write("{0,1}", num);
            }
            Console.Write("{0,1}", "program 1 end");
//**************************************************************************************** program 2
            //XElement contacts = XElement.Load(@"c:\myContactList.xml");
            //DataContext db = new DataContext(@"c:\northwind\northwnd.mdf");
            List<int> numQuery2 =
            (from num in numbers
             where (num % 2) == 0
             select num).ToList();
//**************************************************************************************** program 3
            var numQuery3 =
           (from num in numbers
            where (num % 2) == 0
            select num).ToArray();
//**************************************************************************************** program 4
            var numq =
                from num in numbers
                where num > 2
                orderby num descending
                select num;
            Console.WriteLine("\n---------------program 4-----------------\n");
            foreach (int num in numq)
            {
                Console.Write("{0,1}", num);
            }
//**************************************************************************************** program 5

        string[] words = { "the", "quik", "brown", "fox", "jump" };
        IEnumerable<string> queryf =
            from word in words
            orderby word.Length
            select word;
        Console.WriteLine("\n---------------program 5-----------------\n");
        foreach (string str in queryf)
            Console.WriteLine("\n"+str);
//**************************************************************************************** program 6
        string[] words1 = { "the", "quick", "brown", "fox", "jumps" };
        IEnumerable<string> query = from word in words1
                                    orderby word.Substring(0, 1) descending
                                    select word;
        Console.WriteLine("\n-----------------program 6---------------\n");
        foreach (string str in query)
            Console.WriteLine(str);
//**************************************************************************************** program 7
        string[] words2 = { "the", "quick", "brown", "fox", "jumps" };
        IEnumerable <string> query1 = from word in words2
                                    orderby word.Length, word.Substring(0, 1)
                                    descending
                                    select word;
        foreach (string str in query1)
            Console.WriteLine(str);
//**************************************************************************************** program 8
 
        string[] word3 = { "the" ,"brown", "fox" ,"jumps"};
        IEnumerable<string> query2 =
        from wordi in word3
        orderby wordi.Length, wordi.Substring(0, 1)
        descending
        select wordi;
        foreach (string str2 in word3)
            Console.WriteLine(str2);

        }
    }
}
