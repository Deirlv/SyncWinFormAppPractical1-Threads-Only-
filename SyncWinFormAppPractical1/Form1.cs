using System.Data;
using System.Drawing.Printing;

namespace SyncWinFormAppPractical1
{
    public partial class Form1 : Form
    {
        static int Max { get; set; }

        static int Min { get; set; }

        static double Average { get; set; }

        public Form1()
        {
            CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();
        }
        public void PrintRange(object r)
        {
            if(r is Range)
            {
                var range = (Range)r;

                for (int i = range.Start.Value; i < range.End.Value; i++)
                {
                    if(dataGridView1.InvokeRequired)
                    {
                        dataGridView1.Invoke(new MethodInvoker(delegate
                        {
                            dataGridView1.Rows.Add(i, Thread.CurrentThread.Name);
                        }));
                    }
                    else
                    {
                        dataGridView1.Rows.Add(i, Thread.CurrentThread.Name);
                    }
                    Thread.Sleep(500);
                }
            }
            else
            {
                MessageBox.Show("Error");
            }
        }
        private void buttonStart_Click(object sender, EventArgs e)
        {
            if (numericUpDownStart.Value >= numericUpDownEnd.Value)
            {
                MessageBox.Show("Wrong range input. Error");
                return;
            }
            Range range = new Range(Convert.ToInt32(numericUpDownStart.Value), Convert.ToInt32(numericUpDownEnd.Value));

            for (int i = 0; i < numericUpDownThreads.Value; i++)
            {
                ParameterizedThreadStart threadStart = new ParameterizedThreadStart(PrintRange);
                Thread newThread = new Thread(threadStart);
                newThread.Start(range);
            }
        }

        public static void GenerateListOfNumbers(object arr)
        {
            var array = arr as List<int>;

            if (array == null) return;

            Random random = new Random();

            for (int i = 0; i < 10000; i++)
            {
                array.Add(random.Next(1000));
            }
        }

        public static void FindMax(object arr)
        {
            var array = arr as List<int>;

            if (array == null) return;

            Max = array.Max();
        }

        public static void FindMin(object arr)
        {
            var array = arr as List<int>;

            if (array == null) return;

            Min = array.Min();
        }

        public static void FindAverage(object arr)
        {
            var array = arr as List<int>;

            if (array == null) return;

            Average = array.Average();
        }

        public static void WriteFile(object arr)
        {
            var array = arr as List<int>;

            if (array == null) return;

            using (StreamWriter writer = new StreamWriter("result.txt"))
            {
                foreach (var item in array)
                {
                    writer.WriteLine(item);
                }
                writer.WriteLine();

                writer.WriteLine($"Max - {Max}");
                writer.WriteLine($"Min - {Min}");
                writer.WriteLine($"Average - {Average}");
            }
        }

        private void buttonFileStart_Click(object sender, EventArgs e)
        {
            List<int> arr = new List<int>();

            ParameterizedThreadStart threadStartGenerate = new ParameterizedThreadStart(GenerateListOfNumbers);
            Thread threadGenerate = new Thread(threadStartGenerate);

            ParameterizedThreadStart threadStartMax = new ParameterizedThreadStart(FindMax);
            Thread threadMax = new Thread(threadStartMax);

            ParameterizedThreadStart threadStartMin = new ParameterizedThreadStart(FindMin);
            Thread threadMin = new Thread(threadStartMin);

            ParameterizedThreadStart threadStartAverage = new ParameterizedThreadStart(FindAverage);
            Thread threadAverage = new Thread(threadStartAverage);

            threadGenerate.Start(arr);
            threadGenerate.Join();

            threadMax.Start(arr);
            threadMax.Join();

            threadMin.Start(arr);
            threadMin.Join();

            threadAverage.Start(arr);
            threadAverage.Join();

            ParameterizedThreadStart threadStartFile = new ParameterizedThreadStart(WriteFile);
            Thread threadWriteFile = new Thread(threadStartFile);

            threadWriteFile.Start(arr);

            MessageBox.Show("Your file was successfully written");
        }
    }
}
