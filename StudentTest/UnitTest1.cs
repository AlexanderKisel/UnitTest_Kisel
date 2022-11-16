using UserStory_Men_Cher.Models;
using FluentAssertions;

namespace StudentTest
{
    public class UnitTest1
    {
        public Logic.Logic Students = new Logic.Logic();

        public void FillInormation(ref Student information)
        {
            information.FullName = "FIO";
            information.Gender = Gender.Female;
            information.BirthDay = DateTime.Now.AddYears(-16);
            information.formStudy = FormStudy.Och_Zaoch;
            information.Math = 89;
            information.Russia = 78;
            information.Inform = 90;
        }
        public void DopFillInformation(ref Student information)
        {
            information.FullName = "FIO";
            information.Gender = Gender.Male;
            information.BirthDay = DateTime.Now.AddYears(-16);
            information.formStudy = FormStudy.Och;
            information.Math = 60;
            information.Russia = 60;
            information.Inform = 25;
        }
        [Fact]
        public void AddTest()
        {
            var information = new Student();
            FillInormation(ref information);

            var CheckAdd = Students.Add(information);
            var CheckAll = Students.GetStudents();

            CheckAdd.Should().Be(information);
            CheckAll.Should().HaveCount(1).And.NotBeEmpty();
        }
        [Fact]
        public void ChangeInformation()
        {
            var oldinformation = new Student();
            FillInormation(ref oldinformation);
            var newinformation = new Student();
            DopFillInformation(ref newinformation);

            Students.Add(oldinformation);
            Students.Change(oldinformation, newinformation);

            var CheckAll = Students.GetStudents();

            CheckAll.Should().HaveCount(1).And.NotBeEmpty();
            Assert.Equal(CheckAll[0], newinformation);
        }
        [Fact]
        public void RemoveInformation()
        {
            var information = new Student();
            FillInormation(ref information);
            Students.Add(information);
            Students.Remove(information);
            var CheckAll = Students.GetStudents();
            CheckAll.Should().BeEmpty();
        }
    }
}
