using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;


namespace Homework3_2 //桥接模式
{
    class Matrix        //矩阵辅助类
    {                 //此处代码省略		
    }
    
    interface ImageImp { void doPaint(Matrix m); }//显示像素矩阵m	
    abstract class Image  //抽象图像类
        {
         protected ImageImp imp;

         public void setImageImp(ImageImp imp)
            {
                this.imp = imp;
            }
         public abstract void parseFile(string fileName);
        }
    
        class WindowsImp:ImageImp
        {
            public void doPaint(Matrix m)
            {	//调用Windows系统的绘制函数绘制像素矩阵	
                Console.WriteLine(" 在Windows操作系统中显示图像");
            }
        }
        class LinuxImp : ImageImp
        {
            public void doPaint(Matrix m)
            {
                Console.WriteLine(" 在Linux操作系统中显示图像");
            }
        }
        class UnixImp : ImageImp
        {
            public void doPaint(Matrix m)
            {
                Console.WriteLine(" 在Unix操作系统中显示图像");
            }
        }

        class JPGImage:Image
        {
            public override void parseFile(string fileName)
            {//模拟解析JPG文件并获得一个像素矩阵对象m;	
                Matrix m = new Matrix();
                imp.doPaint(m);
                Console.WriteLine(fileName + ", 格式为JPG");
            }
        }
        class PNGImage : Image
        {
            public override void parseFile(string fileName)
            {
                Matrix m = new Matrix();
                imp.doPaint(m);
                Console.WriteLine(fileName + ", 格式为PNG");
            }
        }
        class GIFImage : Image
        {
            public override void parseFile(string fileName)
            {
                Matrix m = new Matrix();
                imp.doPaint(m);
                Console.WriteLine(fileName + ", 格式为GIF");
            }
        }
        class BMPImage : Image
        {
            public override void parseFile(string fileName)
            {
                Matrix m = new Matrix();
                imp.doPaint(m);
                Console.WriteLine(fileName + ", 格式为BMP");
            }
        }
        

        class Client
        {
        static void Main(string[] args)
        {
            Image image;
            ImageImp imp;
            image = new JPGImage();
            imp = new WindowsImp();
            image.setImageImp(imp);
            image.parseFile("桥接");
            Console.ReadLine();
        }
    }
}
