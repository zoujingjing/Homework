using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hw1
{
    class Program
    {
        enum MyDate //使用enum创建枚举
        {
            Sun = 0,
            Mon = 1,
            Tue = 2,
            Wed = 3,
            Thi = 4,
            Fri = 5,
            Sat = 6
        }
        
        //结构体
        struct Student
        {
            public string Sid;      //学号
            public string Name;     //姓名
            public string Major;    //专业
            public double Grade1;   //第一项成绩
            public double Grade2;   //第二项成绩
            public bool Pass;       //是否通过
        }

        //is操作符
        static void Test(object o)
        {
            Bus bus;     //声明类Bus的对象bus
            Taxi taxi;   //声明类Taxi的对象taxi

            if (o is Bus)//如果o是类Bus
            {
                Console.WriteLine("o 是类Bus");
                bus = (Bus)o;//可以把o转化为类Bus，而不出现异常
            }
            else if (o is Taxi)//如果o是类Taxi
            {
                Console.WriteLine("o is 类Taxi");
                taxi = (Taxi)o;//可以把o转化为类B，而不出现异常
            }
            else
            {
                Console.WriteLine("o 不是类Bus，也不是类Taxi.");
                Console.WriteLine("o是{0}", o.GetType());//输出o的类型
            }
        }

        static void Main(string[] args)
        {
            int k = (int)DateTime.Now.DayOfWeek;//获取代表星期几的返回值
            switch(k)
            {
               case (int)MyDate.Sun:Console.WriteLine("今天是星期日"); break;
               case (int)MyDate.Mon:Console.WriteLine("今天是星期一"); break;
               case (int)MyDate.Tue:Console.WriteLine("今天是星期二"); break;
               case (int)MyDate.Wed:Console.WriteLine("今天是星期三"); break;
               case (int)MyDate.Thi:Console.WriteLine("今天是星期四"); break;
               case (int)MyDate.Fri:Console.WriteLine("今天是星期五"); break;
               case (int)MyDate.Sat:Console.WriteLine("今天是星期六"); break;
            }
            Console.WriteLine();

           
            Car car = new Car("小汽车");
            car.Show();
            car.GetWheel();

            Bus bus1 = new Bus();
            Taxi taxi1 = new Taxi();

            //判断bus1,taxi1的所属的类
            Test(bus1);
            Test(taxi1);
            Test(123);

            Car car1 = bus1;    //隐式转换
            Bus bus2 = (Bus)car1;   //显示转换
            //Bus bus3 = (Bus)car;   // 出错
            Console.WriteLine();


            int _人数 = 35;
            int _油表 = 40;
            int _公里数 = 30;
            double _耗油量;
            int _加油体积;

            Bus bus = new Bus("公交", _人数, _油表, _公里数);
            bus.Show();
            _耗油量 = bus.计算耗油(_公里数);
            Console.WriteLine("该班次行驶{0}公里所需耗油量为{1}升", _公里数, _耗油量);
            if(_耗油量 > bus._油表)
            {
                Console.WriteLine("当前储油量不够，需要加油");
                _加油体积 = bus._油箱容积 - bus._油表;
                bus.加油(_加油体积);
            }
            else
            {
                Console.WriteLine("当前储油量足够，不需要加油");
            }
            bus.Profit();  //计算该趟班次公交所赚收益
            Console.WriteLine();

            Taxi taxi = new Taxi("出租车");
            taxi._公里数 = 240;
            taxi._油表 = 10;
            taxi.Show();
            _耗油量 = taxi.计算耗油(taxi._公里数);
            Console.WriteLine("出租车此笔生意行驶{0}公里所需耗油量为{1}升", taxi._公里数, _耗油量);
            if (_耗油量 > taxi._油表)
            {
                Console.WriteLine("当前储油量不够，需要加油");
                _加油体积 = taxi._油箱容积 - taxi._油表;
                taxi.加油(_加油体积);
            }
            else
            {
                Console.WriteLine("当前储油量足够，不需要加油");
            }
            taxi.Profit();  //计算出租车此笔生意所赚收益
            Console.WriteLine();
            Console.WriteLine();


            //定义一个结构体数组，包含学生学号、姓名、专业、成绩、及是否通过
            Student[] stu = new Student[4];
            object[] objArray = new object[4];   //定义数组，该数组的长度为4，包含的数据类型为object
            objArray[0] = "20150001";//第3个元素被赋予字符串
            objArray[1] = "20150002";//第4个元素被赋予整型数据
            objArray[2] = "20150003";//第5个元素被赋予浮点数
            objArray[3] = "20150004";//第6个元素被赋予空

            string[] name = new string[4] { "小明", "小红", "小芸", "小康" };
            string[] major = new string[4] { "信管", "电商", "信管", "信资" };
            double[,] grade = new double[2, 4] { { 88, 76.5, 57, 90.5 }, { 85.5, 55, 82.5, 79 } };  //多维数组
            bool[] pass = new bool[4] { false, false, false, false };
            
            //将上述各类数组中的值分别赋给结构体数组
            for (int i = 0; i < 4; i++)
            {
                stu[i].Sid = objArray[i] as string;   //as操作符
                stu[i].Name = name[i];
                stu[i].Major = major[i];
                stu[i].Grade1 = grade[0, i];
                stu[i].Grade2 = grade[1, i];
                if (stu[i].Grade1 >= 60 && stu[i].Grade2 >= 60)   //只有两项成绩均达到60分才能通过
                    stu[i].Pass = true;
            }

            Console.WriteLine("学生成绩信息表：");
            Console.WriteLine();
            Console.WriteLine("学号        姓名     专业    成绩1    成绩2   是否通过");
            Console.WriteLine();
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("{0}    {1}     {2}     {3}      {4}      {5}", stu[i].Sid, stu[i].Name, stu[i].Major, stu[i].Grade1, stu[i].Grade2, stu[i].Pass);
            }
            Console.WriteLine();

            //泛型
            Sort<int> sort = new Sort<int>();
            int[] a = { 56, 72, 90, 10, 57, 28, 105, 34, 95 };   //随机定义一个数组
            Console.Write("原数组为：");
            foreach (int item in a)
            {
                Console.Write(item + ", ");
            }
            Console.WriteLine();
            Console.Write("排序后数组为：");
            sort.BubbleSort(a);
            Console.ReadLine();
        }
    }

    //定义抽象类，表示交通工具
    abstract class Travel
    {
        protected string _name;//交通工具的名称

        public abstract string Name//定义抽象属性，表示交通工具的名称
        {
            get;
            set;
        }

        public void Show()//定义一般方法，用来显示是何种交通工具
        {
            Console.WriteLine("这是{0}", _name);
        }
        public abstract void GetWheel();//获取轮子的数量
    }

    //定义汽车类,继承抽象类Travel
    class Car : Travel
    {
        public int _百公里耗油 = 10;
        public int _油箱容积 = 50;
        public int _油表;
        public int _公里数;

        public int 百公里耗油
        {
            get { return _百公里耗油; }
        }
        public int 油箱容积
        {
            get { return _油箱容积; }
        }
        public int 油表
        {
            get { return _油表; }
            set { _油表 = value; }
        }
        public int 公里数
        {
            get { return _公里数; }
            set { _公里数 = value; }
        }

        //重写抽象类属性
        public override string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }

        //无参构造方法
        public Car()
        {

        }

        //有参构造方法
        public Car(int 当前油表,int 当前里程)
        {
            _油表 = 当前油表;
            _公里数 = 当前里程;
        }

        
        //有参构造方法
        public Car(string name)
        {
            _name = name;
        }

        //重写抽象类方法
        public override void GetWheel()
        {
            Console.WriteLine("汽车有4个轮子");
        }

        //计算耗油
        public double 计算耗油(int 行驶公里数)
        {
            return 行驶公里数 * _百公里耗油 / 100.0;
        }

        //加油
        public void 加油(int 加油体积)
        {
            Console.WriteLine("加油{0}升开始", 加油体积);
            _油表 += 加油体积;
            Console.WriteLine("加油完毕,当前油表为{0}升", _油表);
           
        }
    }

    //定义接口
    interface IProfit
    {
        void Profit();    //计算一趟班次/生意的收益
    }

    //定义公交车类，继承父类Car
    class Bus : Car, IProfit
    {
        private int _人数;    //定义属性，每一趟班次公交共所承载的人的数量
        private double price = 2;   //定义属性票价

        //构造方法
        public Bus()
        {

        }

        public Bus(string name)
        {
            _name = name;
        }

        public Bus(string name,int 人数)
        {
            _name = name;
            _人数 = 人数;
        }

        public Bus(string name,int 人数, int 当前油表, int 当前里程)
        {
            _name = name;
            _人数 = 人数;
            _油表 = 当前油表;
            _公里数 = 当前里程;
        }

        public int 人数
        {
            get { return _人数; }
            set { _人数 = value; }
        }

        public void Profit()  //实现接口方法
        {
            double profit;
            profit = _人数 * price;
            Console.WriteLine("这趟班次收益{0}元", profit);
        }

    }

    //定义出租车类，继承父类Car和接口
    class Taxi : Car, IProfit
    {
        private int basep = 5;    //定义属性起步价5元
        private double price = 2;   //定义属性票价，每公里2元

        //构造方法
        public Taxi()
        {

        }

        public Taxi(string name)
        {
            _name = name;
        }

        public Taxi(string name,int 当前油表, int 当前里程)
        {
            _name = name;
            _油表 = 当前油表;
            _公里数 = 当前里程;
        }
        
        public void Profit()  //实现接口方法
        {
            double profit;
            if (_公里数 <= 2)
                profit = basep;  //如果行驶的公里数不超过2公里，则价格为起步价
            else
                profit = basep + (_公里数 - 2) * price;  //行驶公里数超过2公里的按每公里2元的价格计价
            
            Console.WriteLine("这笔生意收益{0}元", profit);
        }

    }

    //泛型，冒泡排序
    public class Sort<T> where T : IComparable      //由于排序过程中需要对元素进行比较，所以要实现IComparable接口
    {
        public void BubbleSort(T[] array)    //冒泡排序，从大到小进行排列
        {
            int m = array.Length - 1;
            for (int j = 0; j < m; j++)
            {
                for (int i = 0; i < m - j; i++)
                {
                    if (array[i].CompareTo(array[i + 1]) < 0)
                    {
                        T t = array[i];
                        array[i] = array[i + 1];
                        array[i + 1] = t;
                    }
                }
            }
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + ", ");
            }
            Console.WriteLine();
        }
    }
}
