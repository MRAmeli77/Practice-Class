using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeClass
{
    class classStudent : classUser
    {
        //variables
        private string id;
        private string firstName { get; }
        private string lastName { get; }
        private int numberYearFromStart;
        private bool term;
        //1 = student, 2 = TA
        private int accessLevel;
        //to access app database
        private database_practiceclassEntities database;

        //methods
        public classStudent(string newID, database_practiceclassEntities newDatabase, bool newIsTA, int newNumberYearFromStart, bool newTerm)
        {
            //set values on creat
            this.id = newID;
            this.accessLevel = newIsTA ? 2 : 1;
            this.database = newDatabase;
            this.numberYearFromStart = newNumberYearFromStart;
            this.term = newTerm;
        }
        //returns student homePage's list of classes as a list of struct "ShowClass"
        public override string GetID()
        {
           return this.id;
        }
        public override int GetAccessLevel()
        {
            return this.accessLevel;
        }
        public List<ShowClass> GetStudentClassesList()
        {
            List<ShowClass> result = new List<ShowClass>();
            //select values from database
            var practiceClasses = from practiceClass in database.viewstudentlistclass
                                  where (
                                  practiceClass.numberYearFromStart == this.numberYearFromStart &&
                                  practiceClass.termPracticeClass == this.term &&
                                  practiceClass.status == true &&
                                  practiceClass.idStudent == this.id
                                  )
                                  select new
                                  {
                                      nameCourse = practiceClass.nameCourse,
                                      fullNameTA = practiceClass.tafn + ' ' + practiceClass.talnm,
                                      fullNameProfessor = practiceClass.proffnam + ' ' + practiceClass.proflnam
                                  };
            //add values to list

            foreach (var item in practiceClasses)
                result.Add(new ShowClass { nameCourse = item.nameCourse, fullNameTA = item.fullNameTA, fullNameProfessor = item.fullNameProfessor });
            return result;
        }
    }
}
