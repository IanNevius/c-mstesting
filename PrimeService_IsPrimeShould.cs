using Microsoft.VisualStudio.TestTools.UnitTesting;
using Prime.Services;

namespace Prime.UnitTests.Services
{
    [TestClass]
    public class PrimeService_IsPrimeShould
    {
        //Creating an object of the class we want to test
        private readonly PrimeService _primeService;

        public PrimeService_IsPrimeShould()
        {
            _primeService = new PrimeService();
        } 

        /*This method is testing the IsNumber method
         * Each datarow will be tested and return true or false
        */
        [TestMethod]
        [DataRow("test")]
        [DataRow("1")]
        [DataRow("!!!")]
        [DataRow("!%$&#")]
        [DataRow("42985")]
        [DataRow("lFjKm")]
        [DataRow("00000000000000000000000")]
        [DataRow("10101010110")]
        [DataRow("%&$*#")]
        [DataRow("")]
        [DataRow("null")]
        [DataRow("23")]
        [DataRow("7")]
        [DataRow("*")]
        [DataRow("2test2")]
        [DataRow("0")]
        [DataRow("\\")]
        [DataRow("{}")]
        [DataRow("[]")]
        [DataRow("@")]
        [DataRow("53172")]
        [DataRow("int")]
        [DataRow("000012")]
        [DataRow("number")]
        [DataRow("\n")]
        public void IsNumber_Test(string value)
        {
            bool result = _primeService.IsNumber(value);
            Assert.IsTrue(result, $"{value} is not a number");
        }


        /*This method is testing the IsLetter method
         * Each datarow will be tested and return true or false
        */
        [TestMethod]
        [DataRow("test")]
        [DataRow("1")]
        [DataRow("!!!")]
        [DataRow("!%$&#")]
        [DataRow("42985")]
        [DataRow("lFjKm")]
        [DataRow("00000000000000000000000")]
        [DataRow("10101010110")]
        [DataRow("%&$*#")]
        [DataRow("")]
        [DataRow("null")]
        [DataRow("23")]
        [DataRow("7")]
        [DataRow("*")]
        [DataRow("2test2")]
        [DataRow("0")]
        [DataRow("\\")]
        [DataRow("{}")]
        [DataRow("[]")]
        [DataRow("@")]
        [DataRow("53172")]
        [DataRow("int")]
        [DataRow("000012")]
        [DataRow("number")]
        [DataRow("\n")]
        public void IsLetter_Test(string value)
        {
            bool result = _primeService.IsLetter(value);
            Assert.IsTrue(result, $"{value} is not a letter");
        }


        /*This method is testing the ValidSSN method
         * Each datarow will be tested and return true or false
        */
        [TestMethod]
        [DataRow("123-45-6789")]
        [DataRow("123-aa-6789")]
        [DataRow("53172")]
        [DataRow("int")]
        [DataRow("000012")]
        [DataRow("number")]
        [DataRow("\n")]
        [DataRow("-45-6789")]
        [DataRow("000-00-0000")]
        [DataRow("123456789")]
        [DataRow("123aa6789")]
        [DataRow("123-77-6789")]
        [DataRow("123-45-7777")]
        public void ValidSsn_Test(string value)
        {

            bool result = _primeService.ValidSsn(value);
            Assert.IsTrue(result, $"{value} is not a valid SSN");

        }

    }
}