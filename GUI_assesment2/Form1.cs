using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace GUI_assesment2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int[] n_inter = new int[24];
        int temp_int;
        int place = 0;

        private void add_data_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            for (int i = 0; i < 24; i++)
            {
                n_inter[i] = rnd.Next(10, 90);
            }
            /*
            n_inter[place] = temp_int;
            place++;
            if (place == 24)
            {
                place = 0;
            }
            */
            n_data.Items.Clear();
            foreach (int val in n_inter)
            {
                n_data.Items.Add(val);
            }
        }

        private void sorting_button_Click(object sender, EventArgs e)
        {
            int temp = 0;

            for (int s_index = 0; s_index < n_inter.Length; s_index++)
            {
                for (int sort = 0; sort < n_inter.Length - 1; sort++)
                {

                    if (n_inter[sort] > n_inter[sort + 1])
                    {
                        temp = n_inter[sort + 1];
                        n_inter[sort + 1] = n_inter[sort];
                        n_inter[sort] = temp;

                        n_data.Items.Clear();
                        foreach (int num in n_inter)
                        {
                            n_data.Items.Add(num);
                        }

                    }
                }
                n_data.Items.Clear();
                foreach (int num in n_inter)
                {
                    n_data.Items.Add(num);
                }

            }
        }

        private void search_button_Click(object sender, EventArgs e)
        {
            int min = 0;
            int max = n_inter.Length - 1;
            int.TryParse(search_input.Text, out int search_num);

            while(min <= max)
            {
                int middle = (min + max) / 2;
                if (search_num == n_inter[middle])
                {
                    search_ans.Items.Add("found at index " + middle);
                    search_input.Clear();
                    return;
                }
                else if (n_inter[middle] >= search_num)
                {
                    max = middle - 1;
                }
                else
                {
                    min = middle + 1;
                }
            }
            search_ans.Items.Add("not found :(");
            search_input.Clear();
        }

        private void change_Click(object sender, EventArgs e)
        {
            int.TryParse(index_1.Text, out int place);
            int.TryParse(num_replace.Text, out int replace);
            n_inter[place] = replace;
            n_data.Items.Clear();
            foreach(int num in n_inter)
            {
                n_data.Items.Add(num);
            }
        }

        private void MidExtreme_Click(object sender, EventArgs e)
        {
            float max_x = n_inter.Max();
            float min_x = n_inter.Min();
            float mid_extreme = (max_x + min_x) / 2;
            string m_e = mid_extreme.ToString("0.00");
            MidExtremeBox.Text = m_e;
        }

        private void ModeButton_Click(object sender, EventArgs e)
        {
            var groups = n_inter.GroupBy(v => v);
            int maxCount = groups.Max(g => g.Count());
            float mode = groups.First(g => g.Count() == maxCount).Key;

            string mode_num = mode.ToString("0.00");
            ModeDisplay.Text = mode_num;
        }

        private void AverageButton_Click(object sender, EventArgs e)
        {
            double avg = Queryable.Average(n_inter.AsQueryable());
            string average = avg.ToString("0.00");
            AverageDisplay.Text = average;

        }

        private void RangeButton_Click(object sender, EventArgs e)
        {
            float range = (n_inter.Max() - n_inter.Min());
            string rng = range.ToString("0.00");
            RangeDisplay.Text = rng;
        }

        private void SequentialSearch_Click(object sender, EventArgs e)
        {
            bool found = false;
            int.TryParse(search_input.Text, out int target);
            for (int x = 0; x < n_inter.Length; x++)
            {
                if (n_inter[x] == target)
                {
                    search_ans.Items.Add(" Found at index " + x);
                    search_input.Clear();
                    return;
                }
            }
            if (!found)
            {
                search_ans.Items.Add("Not Found :(");
                search_input.Clear();

            }
        }

        private void RangeDisplay_TextChanged(object sender, EventArgs e)
        {

        }

        private void avg_button_Click(object sender, EventArgs e)
        {
            float total = 0;
            foreach (var item in n_inter)
            {
                total = total + item;
            }
            float average = total / n_inter.Length;
            string avg_ans = average.ToString("0.00");
            avg_out.Text = avg_ans;
        }
    }
}
