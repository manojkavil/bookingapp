using Microsoft.Extensions.Configuration;
using System;
using Xunit;
using FluentAssertions;
using FluentAssertions.Extensions;
using Moq;
using HappierLiving.Appointment.Entity;
using System.Collections.Generic;
using System.Linq;

namespace HappierLiving.Appointment.Repository.Tests
{
    public class StudentRepositoryTests
    {
        private TimeSpan METHOD_EXECUTION_TIME = 300.Milliseconds();

        public readonly IStudentRepository MockStudentRepository;
        public StudentRepositoryTests()
        {
            IList<StudentEntity> students = new List<StudentEntity>
            {
                new StudentEntity{ Name="Alex",  Id=1 },
                new StudentEntity{ Name= "Sam", Id=2 },
                new StudentEntity{ Name="Martin", Id=3 }
            };


            // Mock the Student Repository using Moq
           Mock<IStudentRepository> mockStudentRepository = new Mock<IStudentRepository>();

            mockStudentRepository.Setup(s => s.Delete(It.IsAny<int>()))
                                            .Returns((int id) => students.Where(x => x.Id == id).Count());

            // Complete the setup of our Mock Student Repository
            this.MockStudentRepository = mockStudentRepository.Object;


        }

        [Fact]
        public void Delete_Student_With_Valid_Id()
        {          
            int deletedRecords = MockStudentRepository.Delete(1);

            deletedRecords.Should().Be(1);

        }
        [Fact]
        public void Delete_Student_With_Invalid_Id()
        {
            int deletedRecords = MockStudentRepository.Delete(100);

            deletedRecords.Should().Be(0);
        }

        [Fact]
        public void Delete_Student_Performance_Check()
        {
            IConfiguration config = TestingConfiguration.Get();
            var sut = new StudentRepository(config);

            sut.ExecutionTimeOf(d => d.Delete(1)).Should().BeLessThan(METHOD_EXECUTION_TIME);

        }

    }


}
