using NUnit.Framework;
using System;

namespace CRM
{
    public class Tests
    {
        #region private attributes
        private Contact? _contact;
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
            string expectedName = _name;

            //when
            string actualName = _contact.Name;

            //then
            Assert.AreEqual(expectedName, actualName);
        }

        [Test]
        public void Firstname_GetValue_Success()
        {
            //given
            //refere to Setup method
            string expectedFirstname = _firstname;

            //when
            string actualFirstname = _contact.Firstname;

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
        public void DateOfBirth_SetValue_Success()
        {
            //given
            //refere to Setup method
            DateTime actualDateOfBirth;
            DateTime currentLastUpdate = _contact.LastUpdate;
            DateTime actualLastUpdate;
            DateTime expectedDateOfBirth = new DateTime(1947, 02, 15);//instead of 1946

            //when
            _contact.DateOfBirth = expectedDateOfBirth;

            //then
            actualDateOfBirth = _contact.DateOfBirth;
            actualLastUpdate = _contact.LastUpdate;

            Assert.AreNotEqual(currentLastUpdate, actualLastUpdate);
            Assert.AreEqual(expectedDateOfBirth, actualDateOfBirth);
        }

        [Test]
        public void Nationality_GetValue_Success()
        {
            //given
            //refere to Setup method
            string expectedNationality = _nationality;

            //when
            string actualNationality = _contact.Nationality;

            //then
            Assert.AreEqual(expectedNationality, actualNationality);
        }

        [Test]
        public void Nationality_SetValue_Success()
        {
            //given
            //refere to Setup method
            DateTime currentLastUpdate = _contact.LastUpdate;
            DateTime actualLastUpdate;
            string expectedNationality = "Allemagne";//instead of France

            //when
            _contact.Nationality = expectedNationality;

            //then
            string actualNationality = _contact.Nationality;
            actualLastUpdate = _contact.LastUpdate;

            Assert.AreNotEqual(currentLastUpdate, actualLastUpdate);
            Assert.AreEqual(expectedNationality, actualNationality);
        }

        [Test]
        public void Email_GetValue_Success()
        {
            //given
            //refere to Setup method
            string expectedEmail = _email;

            //when
            string actualEmail = _contact.Email;

            //then
            Assert.AreEqual(expectedEmail, actualEmail);
        }

        [Test]
        public void Email_SetValue_Success()
        {
            //given
            //refere to Setup method
            DateTime currentLastUpdate = _contact.LastUpdate;
            DateTime actualLastUpdate;
            string expectedEmail = "matthieu.ricard@monk.ti";

            //when
            _contact.Email = expectedEmail;

            //then
            string actualEmail = _contact.Email;
            actualLastUpdate = _contact.LastUpdate;

            Assert.AreNotEqual(currentLastUpdate, actualLastUpdate);
            Assert.AreEqual(expectedEmail, actualEmail);
        }


        [Test]
        public void PathToImg_GetValue_Success()
        {
            //given
            //refere to Setup method
            string expectedPathToImg = _pathToImg;

            //when
            string actualPathToImg = _contact.PathToImg;

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
        public void PathToImg_SetValue_Success()
        {
            //given
            //refere to Setup method
            Contact contact = new Contact(_name, _firstname, _dateOfBirth, _nationality, _email);
            string actualPathToImg = "";
            DateTime currentLastUpdate = contact.LastUpdate;
            DateTime actualLastUpdate;
            string expectedPathToImg = "/myNewImage.png";

            //when
            contact.PathToImg = expectedPathToImg;

            //then
            actualPathToImg = contact.PathToImg;
            actualLastUpdate = contact.LastUpdate;

            Assert.AreNotEqual(currentLastUpdate, actualLastUpdate);
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