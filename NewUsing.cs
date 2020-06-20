using NUnit.Framework;
using System.Collections.Generic;
using System.IO;

namespace CsharpNewVersion
{
    class MyFile: StreamWriter
    {
        public bool IsDead { get; set; } = false;

        public MyFile(string path):base(path)
        {

        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
            IsDead =  true;
        }


    }

    class NewUsing
    {
        private MyFile myFile;

        private void writeLines(IEnumerable<string> lines)
        {
            //using agora usa o contexto do metodo e da dispose assim q sai do metodo
            using var file = new MyFile("test.txt");
            foreach (var line in lines)
                file.WriteLine(line);

            myFile = file;
        }
        [Test]
        public void NewUsingTest()
        {
            writeLines(new string[]
            {
                "t",
                "tt",
                "ttt"
            });

            Assert.That(myFile.IsDead, Is.True);
        }
    }

   


}
