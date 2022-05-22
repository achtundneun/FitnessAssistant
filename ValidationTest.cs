using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FitnessAssistant_Nikitin_Liventsev2ISP11_17Tests
{
    [TestClass]
    public class ValidationTest
    {
        [TestMethod]
        public void ValidationPassword_Lenght7_False()
        {
            //Arrange 
            string password = "Aa1@aaa";
            bool ex = false;

            //Act
            bool act = FitnessAssistant_Nikitin_Liventsev2ISP11_17.Classes.Validation.ValidationPassword(password);

            //Assert
            Assert.AreEqual(ex, act);
        }

        [TestMethod]
        public void ValidationPassword_CorrectPassword_True()
        {
            //Arrange 
            string password = "Aa1@aaaaaa";
            bool ex = true;

            //Act
            bool act = FitnessAssistant_Nikitin_Liventsev2ISP11_17.Classes.Validation.ValidationPassword(password);

            //Assert
            Assert.AreEqual(ex, act);
        }

        [TestMethod]
        public void ValidationPassword_NotSpecialSymbol_False()
        {
            //Arrange 
            string password = "Aa1aaaaa";
            bool ex = false;

            //Act
            bool act = FitnessAssistant_Nikitin_Liventsev2ISP11_17.Classes.Validation.ValidationPassword(password);

            //Assert
            Assert.AreEqual(ex, act);
        }

        [TestMethod]
        public void ValidationPassword_NoNumberlSymbol_False()
        {
            //Arrange 
            string password = "Aa@aaaaa";
            bool ex = false;

            //Act
            bool act = FitnessAssistant_Nikitin_Liventsev2ISP11_17.Classes.Validation.ValidationPassword(password);

            //Assert
            Assert.AreEqual(ex, act);
        }

        [TestMethod]
        public void ValidationPassword_NoUpperlSymbol_False()
        {
            //Arrange 
            string password = "aa1@aaaaa";
            bool ex = false;

            //Act
            bool act = FitnessAssistant_Nikitin_Liventsev2ISP11_17.Classes.Validation.ValidationPassword(password);

            //Assert
            Assert.AreEqual(ex, act);
        }

        [TestMethod]
        public void ValidationPassword_NoLowerlSymbol_False()
        {
            //Arrange 
            string password = "AA1@AAAA";
            bool ex = false;

            //Act
            bool act = FitnessAssistant_Nikitin_Liventsev2ISP11_17.Classes.Validation.ValidationPassword(password);

            //Assert
            Assert.AreEqual(ex, act);
        }

        [TestMethod]
        public void ValidationPassword_NoWhiteSpace_False()
        {
            //Arrange 
            string password = "        ";
            bool ex = false;

            //Act
            bool act = FitnessAssistant_Nikitin_Liventsev2ISP11_17.Classes.Validation.ValidationPassword(password);

            //Assert
            Assert.AreEqual(ex, act);
        }

        [TestMethod]
        public void ValidationPassword_Leeght21_False()
        {
            //Arrange 
            string password = "Aa@121212121212121212";
            bool ex = false;

            //Act
            bool act = FitnessAssistant_Nikitin_Liventsev2ISP11_17.Classes.Validation.ValidationPassword(password);

            //Assert
            Assert.AreEqual(ex, act);
        }

        [TestMethod]
        public void ValidationPassword_Leeght0_False()
        {
            //Arrange 
            string password = "";
            bool ex = false;

            //Act
            bool act = FitnessAssistant_Nikitin_Liventsev2ISP11_17.Classes.Validation.ValidationPassword(password);

            //Assert
            Assert.AreEqual(ex, act);
        }

        [TestMethod]
        public void ValidationPassword_NoSpace_False()
        {
            //Arrange 
            string password = "A@a A@a";
            bool ex = false;

            //Act
            bool act = FitnessAssistant_Nikitin_Liventsev2ISP11_17.Classes.Validation.ValidationPassword(password);

            //Assert
            Assert.AreEqual(ex, act);
        }

        /// <summary>
        /// FullName
        /// </summary>

        [TestMethod]
        public void ValidationFullName_NoNumber_False()
        {
            //Arrange 
            string FullName = "AAAAAA7AAAAA";
            bool ex = false;

            //Act
            bool act = FitnessAssistant_Nikitin_Liventsev2ISP11_17.Classes.Validation.ValidationFullName(FullName);

            //Assert
            Assert.AreEqual(ex, act);
        }

        [TestMethod]
        public void ValidationFullName_Upper_False()
        {
            //Arrange 
            string FullName = "AAAAAAAAAAA";
            bool ex =false;

            //Act
            bool act = FitnessAssistant_Nikitin_Liventsev2ISP11_17.Classes.Validation.ValidationFullName(FullName);

            //Assert
            Assert.AreEqual(ex, act);
        }

        [TestMethod]
        public void ValidationFullName_Length1_False()
        {
            //Arrange
            string FullName = "I";
            bool ex = false;

            //Act
            bool act = FitnessAssistant_Nikitin_Liventsev2ISP11_17.Classes.Validation.ValidationFullName(FullName);

            //Assert
            Assert.AreEqual(ex, act);
        }

        [TestMethod]
        public void ValidationFullName_WithNothing_False()
        {
            //Arrange
            string FullName = "";
            bool ex = false;

            //Act
            bool act = FitnessAssistant_Nikitin_Liventsev2ISP11_17.Classes.Validation.ValidationFullName(FullName);

            //Assert
            Assert.AreEqual(ex, act);
        }

        [TestMethod]
        public void ValidationFullName_Length51_False()
        {
            //Arrange
            string FullName = "Abcdefgqrstuvwxyzabcdefgqrstuvwxyzabcdefgqrstuvwxyz-ht";
            bool ex = false;

            //Act
            bool act = FitnessAssistant_Nikitin_Liventsev2ISP11_17.Classes.Validation.ValidationFullName(FullName);

            //Assert
            Assert.AreEqual(ex, act);
        }

        [TestMethod]
        public void ValidationFullName_OnlySpace_False()
        {
            //Arrange
            string FullName = "      ";
            bool ex = false;

            //Act
            bool act = FitnessAssistant_Nikitin_Liventsev2ISP11_17.Classes.Validation.ValidationFullName(FullName);

            //Assert
            Assert.AreEqual(ex, act);
        }

        [TestMethod]
        public void ValidationFullName_OnlySpecialSimbol_False()
        {
            //Arrange
            string FullName = "--------";
            bool ex = false;

            //Act
            bool act = FitnessAssistant_Nikitin_Liventsev2ISP11_17.Classes.Validation.ValidationFullName(FullName);

            //Assert
            Assert.AreEqual(ex, act);
        }

        [TestMethod]
        public void ValidationFullName_WithSimbols_False()
        {
            //Arrange
            string FullName = "Who-whowho----";
            bool ex = false;

            //Act
            bool act = FitnessAssistant_Nikitin_Liventsev2ISP11_17.Classes.Validation.ValidationFullName(FullName);

            //Assert
            Assert.AreEqual(ex, act);
        }

        [TestMethod]
        public void ValidationFullName_WithSimbol_True()
        {
            //Arrange
            string FullName = "Name-cool";
            bool ex = true;

            //Act
            bool act = FitnessAssistant_Nikitin_Liventsev2ISP11_17.Classes.Validation.ValidationFullName(FullName);

            //Assert
            Assert.AreEqual(ex, act);
        }

        [TestMethod]
        public void ValidationFullName_WithSpace_True()
        {
            //Arrange
            string FullName = "Name Cool";
            bool ex = true;

            //Act
            bool act = FitnessAssistant_Nikitin_Liventsev2ISP11_17.Classes.Validation.ValidationFullName(FullName);

            //Assert
            Assert.AreEqual(ex, act);
        }

        [TestMethod]
        public void ValidationFullName_WithSimbolAndSpace_True()
        {
            //Arrange
            string FullName = "Name cool-fool";
            bool ex = true;

            //Act
            bool act = FitnessAssistant_Nikitin_Liventsev2ISP11_17.Classes.Validation.ValidationFullName(FullName);

            //Assert
            Assert.AreEqual(ex, act);
        }

        [TestMethod]
        public void ValidationFullName_WithSimbolAndTwoSpace_False()
        {
            //Arrange
            string FullName = "Name  cool-fool";
            bool ex = false;

            //Act
            bool act = FitnessAssistant_Nikitin_Liventsev2ISP11_17.Classes.Validation.ValidationFullName(FullName);

            //Assert
            Assert.AreEqual(ex, act);
        }

        [TestMethod]
        public void ValidationFullName_WithSpaceAndNumber_False()
        {
            //Arrange
            string FullName = "Name cool8";
            bool ex = false;

            //Act
            bool act = FitnessAssistant_Nikitin_Liventsev2ISP11_17.Classes.Validation.ValidationFullName(FullName);

            //Assert
            Assert.AreEqual(ex, act);
        }

        [TestMethod]
        public void ValidationFullName_WithNoSimbols_True()
        {
            //Arrange
            string FullName = "Namecool";
            bool ex = true;

            //Act
            bool act = FitnessAssistant_Nikitin_Liventsev2ISP11_17.Classes.Validation.ValidationFullName(FullName);

            //Assert
            Assert.AreEqual(ex, act);
        }

        [TestMethod]
        public void ValidationFullName_WithOneSimbols_false()
        {
            //Arrange
            string FullName = "-";
            bool ex = false;

            //Act
            bool act = FitnessAssistant_Nikitin_Liventsev2ISP11_17.Classes.Validation.ValidationFullName(FullName);

            //Assert
            Assert.AreEqual(ex, act);
        }

        /// <summary>
        /// Login
        /// </summary>
        [TestMethod]
        public void ValidationLogin_CorrectLogin_True()
        {
            //Arrange
            string Login = "123Lololo@";
            bool ex = true;

            //Act
            bool act = FitnessAssistant_Nikitin_Liventsev2ISP11_17.Classes.Validation.ValidationLogin(Login);

            //Assert
            Assert.AreEqual(ex, act);
        }

        [TestMethod]
        public void ValidationLogin_Length4_False()
        {
            //Arrange
            string Login = "1Aa@";
            bool ex = false;

            //Act
            bool act = FitnessAssistant_Nikitin_Liventsev2ISP11_17.Classes.Validation.ValidationLogin(Login);

            //Assert
            Assert.AreEqual(ex, act);
        }

        [TestMethod]
        public void ValidationPassword_Length51_False()
        {
            //Arrange
            string Login = "123Lololo#228a22c873r2jd23r-wtfjR5jrhf3kr6372af53W5";
            bool ex = false;

            //Act
            bool act = FitnessAssistant_Nikitin_Liventsev2ISP11_17.Classes.Validation.ValidationLogin(Login);

            //Assert
            Assert.AreEqual(ex, act);
        }

        [TestMethod]
        public void ValidationLogin_Length0_False()
        {
            //Arrange
            string Login = "";
            bool ex = false;

            //Act
            bool act = FitnessAssistant_Nikitin_Liventsev2ISP11_17.Classes.Validation.ValidationLogin(Login);

            //Assert
            Assert.AreEqual(ex, act);
        }

        [TestMethod]
        public void ValidationLogin_NoSpecialSimbol_False()
        {
            //Arrange
            string Login = "123Lolol";
            bool ex = false;

            //Act
            bool act = FitnessAssistant_Nikitin_Liventsev2ISP11_17.Classes.Validation.ValidationLogin(Login);

            //Assert
            Assert.AreEqual(ex, act);
        }

        [TestMethod]
        public void ValidationLogin_NoUpper_False()
        {
            //Arrange
            string Login = "123ikjfj@";
            bool ex = false;

            //Act
            bool act = FitnessAssistant_Nikitin_Liventsev2ISP11_17.Classes.Validation.ValidationLogin(Login);

            //Assert
            Assert.AreEqual(ex, act);
        }

        [TestMethod]
        public void ValidationLogin_NoLower_False()
        {
            //Arrange
            string Login = "111A@";
            bool ex = false;

            //Act
            bool act = FitnessAssistant_Nikitin_Liventsev2ISP11_17.Classes.Validation.ValidationLogin(Login);

            //Assert
            Assert.AreEqual(ex, act);
        }

        [TestMethod]
        public void ValidationLogin_NoLeters_False()
        {
            //Arrange
            string Login = "11111?!@";
            bool ex = false;

            //Act
            bool act = FitnessAssistant_Nikitin_Liventsev2ISP11_17.Classes.Validation.ValidationLogin(Login);

            //Assert
            Assert.AreEqual(ex, act);
        }

        [TestMethod]
        public void ValidationLogin_NoDigit_False()
        {
            //Arrange
            string Login = "@?!Loollol";
            bool ex = false;

            //Act
            bool act = FitnessAssistant_Nikitin_Liventsev2ISP11_17.Classes.Validation.ValidationLogin(Login);

            //Assert
            Assert.AreEqual(ex, act);
        }

        [TestMethod]
        public void ValidationLogin_WhiteSpace_False()
        {
            //Arrange
            string Login = "123Mag ist@";
            bool ex = false;

            //Act
            bool act = FitnessAssistant_Nikitin_Liventsev2ISP11_17.Classes.Validation.ValidationLogin(Login);

            //Assert
            Assert.AreEqual(ex, act);
        }

        [TestMethod]
        public void ValidationLogin_OnlyWhiteSpace_False()
        {
            //Arrange
            string Login = "       ";
            bool ex = false;

            //Act
            bool act = FitnessAssistant_Nikitin_Liventsev2ISP11_17.Classes.Validation.ValidationLogin(Login);

            //Assert
            Assert.AreEqual(ex, act);
        }

        /// <summary>
        /// WEIGHTANDHEIGHT
        /// </summary>

        [TestMethod]
        public void ValidationWeightAndHeight_Correct_True()
        {
            //Arrange
            string WeightAndHeight = "123";
            bool ex = true;

            //Act
            bool act = FitnessAssistant_Nikitin_Liventsev2ISP11_17.Classes.Validation.ValidationWeightAndHeight(WeightAndHeight);

            //Assert
            Assert.AreEqual(ex, act);
        }

        [TestMethod]
        public void ValidationWeightAndHeight_IsZero_false()
        {
            //Arrange
            string WeightAndHeight = "0";
            bool ex = false;

            //Act
            bool act = FitnessAssistant_Nikitin_Liventsev2ISP11_17.Classes.Validation.ValidationWeightAndHeight(WeightAndHeight);

            //Assert
            Assert.AreEqual(ex, act);
        }

        [TestMethod]
        public void ValidationWeightAndHeight_Is4301_False()
        {
            //Arrange
            string WeightAndHeight = "301";
            bool ex = false;

            //Act
            bool act = FitnessAssistant_Nikitin_Liventsev2ISP11_17.Classes.Validation.ValidationWeightAndHeight(WeightAndHeight);

            //Assert
            Assert.AreEqual(ex, act);
        }

        [TestMethod]
        public void ValidationWeightAndHeight_Sumbols_False()
        {
            //Arrange
            string WeightAndHeight = "#####";
            bool ex = false;

            //Act
            bool act = FitnessAssistant_Nikitin_Liventsev2ISP11_17.Classes.Validation.ValidationWeightAndHeight(WeightAndHeight);

            //Assert
            Assert.AreEqual(ex, act);
        }

        [TestMethod]
        public void ValidationWeightAndHeight_Letter_false()
        {
            //Arrange
            string WeightAndHeight = "B";
            bool ex = false;

            //Act
            bool act = FitnessAssistant_Nikitin_Liventsev2ISP11_17.Classes.Validation.ValidationWeightAndHeight(WeightAndHeight);

            //Assert
            Assert.AreEqual(ex, act);
        }

        [TestMethod]
        public void ValidationWeightAndHeight_Space_false()
        {
            //Arrange
            string WeightAndHeight = " ";
            bool ex = false;

            //Act
            bool act = FitnessAssistant_Nikitin_Liventsev2ISP11_17.Classes.Validation.ValidationWeightAndHeight(WeightAndHeight);

            //Assert
            Assert.AreEqual(ex, act);
        }

        [TestMethod]
        public void ValidationWeightAndHeight_Nothing_false()
        {
            //Arrange
            string WeightAndHeight = "";
            bool ex = false;

            //Act
            bool act = FitnessAssistant_Nikitin_Liventsev2ISP11_17.Classes.Validation.ValidationWeightAndHeight(WeightAndHeight);

            //Assert
            Assert.AreEqual(ex, act);
        }


        /// <summary>
        /// BMI
        /// </summary>
        [TestMethod]
        public void ValidationBMI_CorrectBMI_True()
        {
            //Arrange
            double Weight = 111;
            double Height = 200;
            double BMI = Weight / ((Height / 100) * (Height / 100));
            bool ex = true;

            //Act
            bool act = FitnessAssistant_Nikitin_Liventsev2ISP11_17.Classes.Validation.ValidationBMI(Convert.ToString(BMI), Convert.ToString(Weight), Convert.ToString(Height));

            //Assert
            Assert.AreEqual(ex, act);
        }

        [TestMethod]
        public void ValidationBMI_WeightMinus_False()
        {
            //Arrange
            double Weight = -111;
            double Height = 200;
            double BMI = Weight / ((Height / 100) * (Height / 100));
            bool ex = false;

            //Act
            bool act = FitnessAssistant_Nikitin_Liventsev2ISP11_17.Classes.Validation.ValidationBMI(Convert.ToString(BMI), Convert.ToString(Weight), Convert.ToString(Height));

            //Assert
            Assert.AreEqual(ex, act);
        }

        [TestMethod]
        public void ValidationBMI_HeightMinus_False()
        {
            //Arrange
            double Weight = 111;
            double Height = -200;
            double BMI = Weight / ((Height / 100) * (Height / 100));
            bool ex = false;

            //Act
            bool act = FitnessAssistant_Nikitin_Liventsev2ISP11_17.Classes.Validation.ValidationBMI(Convert.ToString(BMI), Convert.ToString(Weight), Convert.ToString(Height));

            //Assert
            Assert.AreEqual(ex, act);
        }

        [TestMethod]
        public void ValidationBMI_WeightAndHeightMinus_False()
        {
            //Arrange
            double Weight = -111;
            double Height = -200;
            double BMI = Weight / ((Height / 100) * (Height / 100));
            bool ex = false;

            //Act
            bool act = FitnessAssistant_Nikitin_Liventsev2ISP11_17.Classes.Validation.ValidationBMI(Convert.ToString(BMI), Convert.ToString(Weight), Convert.ToString(Height));

            //Assert
            Assert.AreEqual(ex, act);
        }

        [TestMethod]
        public void ValidationBMI_BMIMinus_False()
        {
            //Arrange
            double Weight = 111;
            double Height = 200;
            double BMI = -(Weight / ((Height / 100) * (Height / 100)));
            bool ex = false;

            //Act
            bool act = FitnessAssistant_Nikitin_Liventsev2ISP11_17.Classes.Validation.ValidationBMI(Convert.ToString(BMI), Convert.ToString(Weight), Convert.ToString(Height));

            //Assert
            Assert.AreEqual(ex, act);
        }

        [TestMethod]
        public void ValidationBMI_WeightAndHeightAndBMIMinus_False()
        {
            //Arrange
            double Weight = -111;
            double Height = -200;
            double BMI = -(Weight / ((Height / 100) * (Height / 100)));
            bool ex = false;

            //Act
            bool act = FitnessAssistant_Nikitin_Liventsev2ISP11_17.Classes.Validation.ValidationBMI(Convert.ToString(BMI), Convert.ToString(Weight), Convert.ToString(Height));

            //Assert
            Assert.AreEqual(ex, act);
        }

        [TestMethod]
        public void ValidationBMI_Weight10_False()
        {
            //Arrange
            double Weight = 10;
            double Height = 200;
            double BMI = Weight / ((Height / 100) * (Height / 100));
            bool ex = false;

            //Act
            bool act = FitnessAssistant_Nikitin_Liventsev2ISP11_17.Classes.Validation.ValidationBMI(Convert.ToString(BMI), Convert.ToString(Weight), Convert.ToString(Height));

            //Assert
            Assert.AreEqual(ex, act);
        }

        [TestMethod]
        public void ValidationBMI_Height9_False()
        {
            //Arrange
            double Weight = 111;
            double Height = 9;
            double BMI = Weight / ((Height / 100) * (Height / 100));
            bool ex = false;

            //Act
            bool act = FitnessAssistant_Nikitin_Liventsev2ISP11_17.Classes.Validation.ValidationBMI(Convert.ToString(BMI), Convert.ToString(Weight), Convert.ToString(Height));

            //Assert
            Assert.AreEqual(ex, act);
        }

        [TestMethod]
        public void ValidationBMI_Weight5555_False()
        {
            //Arrange
            double Weight = 5555;
            double Height = 200;
            double BMI = Weight / ((Height / 100) * (Height / 100));
            bool ex = false;

            //Act
            bool act = FitnessAssistant_Nikitin_Liventsev2ISP11_17.Classes.Validation.ValidationBMI(Convert.ToString(BMI), Convert.ToString(Weight), Convert.ToString(Height));

            //Assert
            Assert.AreEqual(ex, act);
        }

        [TestMethod]
        public void ValidationBMI_Height290_False()
        {
            //Arrange
            double Weight = 111;
            double Height = 290;
            double BMI = Weight / ((Height / 100) * (Height / 100));
            bool ex = false;

            //Act
            bool act = FitnessAssistant_Nikitin_Liventsev2ISP11_17.Classes.Validation.ValidationBMI(Convert.ToString(BMI), Convert.ToString(Weight), Convert.ToString(Height));

            //Assert
            Assert.AreEqual(ex, act);
        }

        /// <summary>
        /// BMR
        /// </summary>
        [TestMethod]
        public void ValidationBMR_CorrectBMRWoman_True()
        {
            //Arrange
            double Weight = 70;
            double Height = 165;
            int Age = 21;
            int Gender = 2;
            double BMR = 66 + (13.7 + Weight) + (5 + (Height / 100)) - (6.8 + Age);
            bool ex = true;

            //Act
            bool act = FitnessAssistant_Nikitin_Liventsev2ISP11_17.Classes.Validation.ValidationBMR(Convert.ToString(BMR), Convert.ToString(Weight), Convert.ToString(Height), Convert.ToString(Age), Convert.ToString(Gender));

            //Assert
            Assert.AreEqual(ex, act);
        }

        [TestMethod]
        public void ValidationBMR_CorrectBMRMan_True()
        {
            //Arrange
            double Weight = 111;
            double Height = 200;
            int Age = 20;
            int Gender = 1;
            double BMR = 655 + (9.8 + Weight) + (1.8 + (Height / 100)) - (4.7 + Age);
            bool ex = true;

            //Act
            bool act = FitnessAssistant_Nikitin_Liventsev2ISP11_17.Classes.Validation.ValidationBMR(Convert.ToString(BMR), Convert.ToString(Weight), Convert.ToString(Height), Convert.ToString(Age), Convert.ToString(Gender));

            //Assert
            Assert.AreEqual(ex, act);
        }

        [TestMethod]
        public void ValidationBMR_WeightMinusGenderMan_False()
        {
            //Arrange
            double Weight = -111;
            double Height = 200;
            int Age = 20;
            int Gender = 1;
            double BMR = 66 + (13.7 + Weight) + (5 + (Height / 100)) - (6.8 + Age);
            bool ex = false;

            //Act
            bool act = FitnessAssistant_Nikitin_Liventsev2ISP11_17.Classes.Validation.ValidationBMR(Convert.ToString(BMR), Convert.ToString(Weight), Convert.ToString(Height), Convert.ToString(Age), Convert.ToString(Gender));

            //Assert
            Assert.AreEqual(ex, act);
        }

        [TestMethod]
        public void ValidationBMR_HeightMinusMan_False()
        {
            //Arrange
            double Weight = 111;
            double Height = -200;
            int Age = 20;
            int Gender = 1;
            double BMR = 66 + (13.7 + Weight) + (5 + (Height / 100)) - (6.8 + Age);
            bool ex = false;

            //Act
            bool act = FitnessAssistant_Nikitin_Liventsev2ISP11_17.Classes.Validation.ValidationBMR(Convert.ToString(BMR), Convert.ToString(Weight), Convert.ToString(Height), Convert.ToString(Age), Convert.ToString(Gender));

            //Assert
            Assert.AreEqual(ex, act);
        }

        [TestMethod]
        public void ValidationBMR_AgeMinusGenderMan_False()
        {
            //Arrange
            double Weight = 111;
            double Height = 200;
            int Age = -20;
            int Gender = 1;
            double BMR = 66 + (13.7 + Weight) + (5 + (Height / 100)) - (6.8 + Age);
            bool ex = false;

            //Act
            bool act = FitnessAssistant_Nikitin_Liventsev2ISP11_17.Classes.Validation.ValidationBMR(Convert.ToString(BMR), Convert.ToString(Weight), Convert.ToString(Height), Convert.ToString(Age), Convert.ToString(Gender));

            //Assert
            Assert.AreEqual(ex, act);
        }

        [TestMethod]
        public void ValidationBMR_BMRMinusGenderMan_False()
        {
            //Arrange
            double Weight = 111;
            double Height = 200;
            int Age = 20;
            int Gender = -1;
            double BMR = -(66 + (13.7 + Weight) + (5 + (Height / 100)) - (6.8 + Age));
            bool ex = false;

            //Act
            bool act = FitnessAssistant_Nikitin_Liventsev2ISP11_17.Classes.Validation.ValidationBMR(Convert.ToString(BMR), Convert.ToString(Weight), Convert.ToString(Height), Convert.ToString(Age), Convert.ToString(Gender));

            //Assert
            Assert.AreEqual(ex, act);
        }

        [TestMethod]
        public void ValidationBMR_BMRAndWeightAndHeightAndAgeAndGenderManAndMinus_False()
        {
            //Arrange
            double Weight = -80;
            double Height = -190;
            int Age = -19;
            int Gender = -1;
            double BMR = -(66 + (13.7 + Weight) + (5 + (Height / 100)) - (6.8 + Age));
            bool ex = false;

            //Act
            bool act = FitnessAssistant_Nikitin_Liventsev2ISP11_17.Classes.Validation.ValidationBMR(Convert.ToString(BMR), Convert.ToString(Weight), Convert.ToString(Height), Convert.ToString(Age), Convert.ToString(Gender));

            //Assert
            Assert.AreEqual(ex, act);
        }

        [TestMethod]
        public void ValidationBMR_WeightMinusWeightWoman_False()
        {
            //Arrange
            double Weight = -111;
            double Height = 200;
            int Age = 20;
            int Gender = 2;
            double BMR = 655 + (9.8 + Weight) + (1.8 + (Height / 100)) - (4.7 + Age);
            bool ex = false;

            //Act
            bool act = FitnessAssistant_Nikitin_Liventsev2ISP11_17.Classes.Validation.ValidationBMR(Convert.ToString(BMR), Convert.ToString(Weight), Convert.ToString(Height), Convert.ToString(Age), Convert.ToString(Gender));

            //Assert
            Assert.AreEqual(ex, act);
        }

        [TestMethod]
        public void ValidationBMR_HeightMinusHeightMan_False()
        {
            //Arrange
            double Weight = 111;
            double Height = -200;
            int Age = 20;
            int Gender = 1;
            double BMR = 655 + (9.8 + Weight) + (1.8 + (Height / 100)) - (4.7 + Age);
            bool ex = false;

            //Act
            bool act = FitnessAssistant_Nikitin_Liventsev2ISP11_17.Classes.Validation.ValidationBMR(Convert.ToString(BMR), Convert.ToString(Weight), Convert.ToString(Height), Convert.ToString(Age), Convert.ToString(Gender));

            //Assert
            Assert.AreEqual(ex, act);
        }

        [TestMethod]
        public void ValidationBMR_AgeMinusGenderWoman_False()
        {
            //Arrange
            double Weight = 111;
            double Height = 200;
            int Age = 20;
            int Gender = -2;
            double BMR = 655 + (9.8 + Weight) + (1.8 + (Height / 100)) - (4.7 + Age);
            bool ex = false;

            //Act
            bool act = FitnessAssistant_Nikitin_Liventsev2ISP11_17.Classes.Validation.ValidationBMR(Convert.ToString(BMR), Convert.ToString(Weight), Convert.ToString(Height), Convert.ToString(Age), Convert.ToString(Gender));

            //Assert
            Assert.AreEqual(ex, act);
        }

        [TestMethod]
        public void ValidationBMR_BMRAndWeightAndHeightAndAgeAndGenderWomanAndMinus_False()
        {
            //Arrange
            double Weight = -80;
            double Height = -190;
            int Age = -20;
            int Gender = -2;
            double BMR = -(655 + (9.8 + Weight) + (1.8 + (Height / 100)) - (4.7 + Age));
            bool ex = false;

            //Act
            bool act = FitnessAssistant_Nikitin_Liventsev2ISP11_17.Classes.Validation.ValidationBMR(Convert.ToString(BMR), Convert.ToString(Weight), Convert.ToString(Height), Convert.ToString(Age), Convert.ToString(Gender));

            //Assert
            Assert.AreEqual(ex, act);
        }

        [TestMethod]
        public void ValidationBMR_Age145_False()
        {
            //Arrange
            double Weight = 111;
            double Height = 200;
            int Age = 145;
            int Gender = 1;
            double BMR = 66 + (13.7 + Weight) + (5 + (Height / 100)) - (6.8 + Age);
            bool ex = false;

            //Act
            bool act = FitnessAssistant_Nikitin_Liventsev2ISP11_17.Classes.Validation.ValidationBMR(Convert.ToString(BMR), Convert.ToString(Weight), Convert.ToString(Height), Convert.ToString(Age), Convert.ToString(Gender));

            //Assert
            Assert.AreEqual(ex, act);
        }

        [TestMethod]
        public void ValidationBMR_Age0_False()
        {
            //Arrange
            double Weight = 111;
            double Height = 200;
            int Age = 0;
            int Gender = 1;
            double BMR = 66 + (13.7 + Weight) + (5 + (Height / 100)) - (6.8 + Age);
            bool ex = false;

            //Act
            bool act = FitnessAssistant_Nikitin_Liventsev2ISP11_17.Classes.Validation.ValidationBMR(Convert.ToString(BMR), Convert.ToString(Weight), Convert.ToString(Height), Convert.ToString(Age), Convert.ToString(Gender));

            //Assert
            Assert.AreEqual(ex, act);
        }

        [TestMethod]
        public void ValidationBMR_FalseGender_False()
        {
            //Arrange
            double Weight = 111;
            double Height = 200;
            int Age = 20;
            int Gender = 10;
            double BMR = 66 + (13.7 + Weight) + (5 + (Height / 100)) - (6.8 + Age);
            bool ex = false;

            //Act
            bool act = FitnessAssistant_Nikitin_Liventsev2ISP11_17.Classes.Validation.ValidationBMR(Convert.ToString(BMR), Convert.ToString(Weight), Convert.ToString(Height), Convert.ToString(Age), Convert.ToString(Gender));

            //Assert
            Assert.AreEqual(ex, act);
        }

        [TestMethod]
        public void ValidationBMR_Weight0_False()
        {
            //Arrange
            double Weight = 0;
            double Height = 111;
            int Age = 20;
            int Gender = 1;
            double BMR = 66 + (13.7 + Weight) + (5 + (Height / 100)) - (6.8 + Age);
            bool ex = false;

            //Act
            bool act = FitnessAssistant_Nikitin_Liventsev2ISP11_17.Classes.Validation.ValidationBMR(Convert.ToString(BMR), Convert.ToString(Weight), Convert.ToString(Height), Convert.ToString(Age), Convert.ToString(Gender));

            //Assert
            Assert.AreEqual(ex, act);
        }

        [TestMethod]
        public void ValidationBMR_Height0_False()
        {
            //Arrange
            double Weight = 111;
            double Height = 0;
            int Age = 20;
            int Gender = 1;
            double BMR = 66 + (13.7 + Weight) + (5 + (Height / 100)) - (6.8 + Age);
            bool ex = false;

            //Act
            bool act = FitnessAssistant_Nikitin_Liventsev2ISP11_17.Classes.Validation.ValidationBMR(Convert.ToString(BMR), Convert.ToString(Weight), Convert.ToString(Height), Convert.ToString(Age), Convert.ToString(Gender));

            //Assert
            Assert.AreEqual(ex, act);
        }

        /// <summary>
        /// Birthday
        /// </summary>

        [TestMethod]
        public void ValidationBirthday_FutureDate_False()
        {
            //Arrange
            DateTime Birthday = Convert.ToDateTime("12/04/2023 20:00:00");
            bool ex = false;

            //Act
            bool act = FitnessAssistant_Nikitin_Liventsev2ISP11_17.Classes.Validation.ValidationBirthday(Birthday);

            //Assert
            Assert.AreEqual(ex, act);
        }

        [TestMethod]
        public void ValidationBirthday_CorrectDate_True()
        {
            //Arrange
            DateTime Birthday = Convert.ToDateTime("07/05/2002 20:00:00");
            bool ex = true;

            //Act
            bool act = FitnessAssistant_Nikitin_Liventsev2ISP11_17.Classes.Validation.ValidationBirthday(Birthday);

            //Assert
            Assert.AreEqual(ex, act);
        }
    }
}