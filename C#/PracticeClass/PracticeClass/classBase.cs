using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeClass
{
    //taples of ClassList
    struct ShowClass
    {
        public string nameCourse;
        public string fullNameTA;
        public string fullNameProfessor;
    }
    //taples of QuizList
    struct ShowQuiz
    {
        public DateTime date;
        public int number; 
    }
    //taples of PracticeList
    struct ShowPractice
    {
        public int number;
        public string link;
        public int part;
        public string idUploader;
    }
    class classBase
    {
        private database_practiceclassEntities database;
        private classUser user { get; set; }
        private bool userType;
        private int numberYearFromStart;
        private bool term;
        public classBase()
        {
            database = new database_practiceclassEntities();
            //set basic App Datas
            //term=this.database.table_systemDatas.termNow;
            //numberYearFromStart= this.database.table_systemDatas.numberYearNow;
        }
        public classStudent LoginStudent(string id, string password)
        {
            //first check if user exists as a Student then check if password is true
            if (database.table_student.Any(user => user.idStudent == id) && database.table_user.Any(user => user.idUser == id && user.password == password))
            {
                //return Class student
                return new classStudent(id, database, this.IsTA(id), numberYearFromStart, term);
            }
            return null;
        }
        //return true if user is a TA for a Class or some classes
        public bool IsTA(string id)
        {
            //return true if exist a class that (TA id = this.id)
            return database.table_practiceclass.Any(Practiceclass => Practiceclass.idTA == id);
        }
        /* //login method and creater of professor
         public classProfessor LoginProfessor(string id, string password)
         {
             //first check if user exists as a professor then check if password is true
             if (database.table_professor.Any(user => user.idProfessor == id) && database.table_user.Any(user => user.idUser == id && user.password == password))
             {
                 //return professor if user is valid
                 return true;
             }
         }*/
        //login method and creater of professor
        /* //return true if user is a PrimeProfessor
        //not implemeted yet...
        public bool IsPrimeProfessor(string id)
        {
            return false;
        }*/
    }
}


