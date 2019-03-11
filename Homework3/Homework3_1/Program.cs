using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3_1   //工厂模式
{
    interface Logger { void writeLog(); }

    interface LoggerFactory { Logger createLogger(); Logger createLogger(object obj); Logger createLogger(string args); }

    class DatabaseLogger : Logger
    {
        public void writeLog()
        { Console.WriteLine("数据库日志记录。"); }
    }

    class FileLogger : Logger
    {
        public void writeLog()
        { Console.WriteLine("文件日志记录。"); }
    }

    class DatabaseLoggerFactory:LoggerFactory
    {
        public Logger createLogger()
        {
            //使用默认方式连接数据库，代码省略		
            Logger logger = new DatabaseLogger();
            //初始化数据库日志记录器，代码省略		
            return logger;
        }
        public Logger createLogger(string args)
        {   //使用参数args作为连接字符串来连接数据库，代码省略		
            Logger logger = new DatabaseLogger();
            //初始化数据库日志记录器，代码省略		
            return logger;
        }
        public Logger createLogger(object obj)
        {   //使用封装在参数obj中的连接字符串来连接数据库，代码省略			
            Logger logger = new DatabaseLogger();
            //使用封装在参数obj中的数据来初始化数据库日志记录器，代码省略	
            return logger;
        }
    }
    class FileLoggerFactory : LoggerFactory
    {
        public Logger createLogger()
        {
            //使用默认方式连接文件，代码省略		
            Logger logger = new FileLogger();
            //初始化文件日志记录器，代码省略		
            return logger;
        }
        public Logger createLogger(string args)
        {   //使用参数args作为连接字符串来连接文件，代码省略		
            Logger logger = new FileLogger();
            //初始化文件日志记录器，代码省略		
            return logger;
        }
        public Logger createLogger(object obj)
        {   //使用封装在参数obj中的连接字符串来连接文件，代码省略			
            Logger logger = new FileLogger();
            //使用封装在参数obj中的数据来初始化文件日志记录器，代码省略	
            return logger;
        }
    }

    class Client
    {
        static void Main(string[] args)
        {
            LoggerFactory factory;
            Logger logger;
            factory = new FileLoggerFactory();
            logger = factory.createLogger();
            logger.writeLog();
            Console.ReadLine();
        }
    }
}
