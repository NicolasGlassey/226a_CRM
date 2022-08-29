using NUnit.Framework;
using System;

namespace CRM
{
    public class Tests
    {
        #region private attributes
        private Contact? _contact = null;
        private string? _name;
        private string? _firstname;
        private DateTime _dateOfBirth;
        private string? _nationality;
        private string? _email;
        private string? _pathToImg;
        #endregion private attributes

        [SetUp]
        public void Setup()
        {
            _name = "Ricard";
            _firstname = "Matthieu";
            _dateOfBirth = new DateTime(1946, 02, 15);
            _nationality = "France";
            _email = "matthieu.ricard@monk.org";
            _pathToImg = "ricard.png";
            _contact = new Contact(_name, _firstname, _dateOfBirth, _nationality, _email, _pathToImg);
        }

        [Test]
        public void Name_GetValue_Success()
        {
            //given
            //refere to Setup method
            string actualName = "";
            string expectedName = "Ricard";
            
            //when
            actualName = _contact.Name;

            //then
            Assert.AreEqual(expectedName, actualName);
        }

        [Test]
        public void Firstname_GetValue_Success()
        {
            //given
            //refere to Setup method
            string actualFirstname = "";
            string expectedFirstname = "Matthieu";

            //when
            actualFirstname = _contact.Firstname;

            //then
            Assert.AreEqual(expectedFirstname, actualFirstname);
        }

        [Test]
        public void DateOfBirth_GetValue_Success()
        {
            //given
            //refere to Setup method
            DateTime actualDateOfBirth;
            DateTime expectedDateOfBirth = new DateTime(1946, 02, 15);

            //when
            actualDateOfBirth = _contact.DateOfBirth;

            //then
            Assert.AreEqual(expectedDateOfBirth, actualDateOfBirth);
        }

        [Test]
        public void Nationality_GetValue_Success()
        {
            //given
            //refere to Setup method
            string actualNationality = "";
            string expectedNationality = "France";

            //when
            actualNationality = _contact.Nationality;

            //then
            Assert.AreEqual(expectedNationality, actualNationality);
        }

        [Test]
        public void Email_GetValue_Success()
        {
            //given
            //refere to Setup method
            string actualEmail = "";
            string expectedEmail = "matthieu.ricard@monk.org";

            //when
            actualEmail = _contact.Email;

            //then
            Assert.AreEqual(expectedEmail, actualEmail);
        }

        [Test]
        public void PathToImg_GetValue_Success()
        {
            //given
            //refere to Setup method
            string actualPathToImg = "";
            string expectedPathToImg = "ricard.png";

            //when
            actualPathToImg = _contact.PathToImg;

            //then
            Assert.AreEqual(expectedPathToImg, actualPathToImg);
        }

        [Test]
        public void PathToImg_GetDefaultValue_Success()
        {
            //given
            //refere to Setup method
            Contact contact = new Contact(_name, _firstname, _dateOfBirth, _nationality, _email);
            string actualPathToImg = "";
            string expectedPathToImg = "/";

            //when
            actualPathToImg = contact.PathToImg;

            //then
            Assert.AreEqual(expectedPathToImg, actualPathToImg);
        }

        [Test]
        public void CreationDate_GetValue_Success()
        {
            //given
            //refere to Setup method
            DateTime actualCreationDate;
            DateTime expectedCreationDate = DateTime.Now;

            //when
            actualCreationDate = _contact.CreationDate;

            //when
            TimeSpan diffCalculated = actualCreationDate - expectedCreationDate;
            TimeSpan diffMaxAccepted = new TimeSpan(0, 0, 1);
            Assert.IsTrue(diffCalculated <= diffMaxAccepted);
        }

        [Test]
        public void LastUpdate_GetValue_Success()
        {
            //given
            //refere to Setup method
            DateTime actualLastUpdate;
            DateTime expectedLastUpdate = DateTime.Now;

            //when
            actualLastUpdate = _contact.LastUpdate;

            //when
            TimeSpan diffCalculated = actualLastUpdate - expectedLastUpdate;
            TimeSpan diffMaxAccepted = new TimeSpan(0, 0, 1);
            Assert.IsTrue(diffCalculated <= diffMaxAccepted);
        }
    }
}