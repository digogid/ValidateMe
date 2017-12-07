using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ValidateMe.Tests
{
    [TestClass]
    public class ValidationsTests
    {
        [TestMethod]
        public void Must_ValidateString()
        {
            string testedString = "x";
            var returnedValidation = testedString.MustHasValue(false);
            Assert.IsTrue(returnedValidation);

            testedString = "12345678901234567890123456789012345678900";
            returnedValidation = testedString.MustBeGreaterThan(40, false);
            Assert.IsTrue(returnedValidation);

            testedString = "This string must be greater than 40 characters.";
            returnedValidation = testedString.MustBeGreaterThan(40, false);
            Assert.IsTrue(returnedValidation);

            testedString = "0123456789012345678901234567890123456789012345678";
            returnedValidation = testedString.MustBeSmallerThan(50, false);
            Assert.IsTrue(returnedValidation);

            testedString = "This string must contains exactly 48 characters.";
            returnedValidation = testedString.MustBeExactLength(48, false);
            Assert.IsTrue(returnedValidation);

            testedString = "";
            returnedValidation = testedString.MustBeExactLength(0, false);
            Assert.IsTrue(returnedValidation);

            testedString = " ";
            returnedValidation = testedString.MustBeExactLength(1, false);
            Assert.IsTrue(returnedValidation);

            testedString = "This string must contains only letters with ç â è";
            returnedValidation = testedString.MustBeAlphabetic(false);
            Assert.IsTrue(returnedValidation);

            testedString = "1231321";
            returnedValidation = testedString.MustBeNumeric(false);
            Assert.IsTrue(returnedValidation);

            testedString = "1A2B 3C 4D 5Ç";
            returnedValidation = testedString.MustBeAlphanumeric(false);
            Assert.IsTrue(returnedValidation);

            testedString = "@[]{}^?!/;.<,>|\\~'\"!@#$%¨&*()-_=+";
            returnedValidation = testedString.MustContainSpecialCharacters(false);
            Assert.IsTrue(returnedValidation);

            testedString = "mustbe@email.com";
            returnedValidation = testedString.MustBeEmail(false);
            Assert.IsTrue(returnedValidation);

            testedString = "must.be@email.com.br";
            returnedValidation = testedString.MustBeEmail(false);
            Assert.IsTrue(returnedValidation);

            testedString = "must_be@email.com.br";
            returnedValidation = testedString.MustBeEmail(false);
            Assert.IsTrue(returnedValidation);

            testedString = "must.be@email.sp.gov.br";
            returnedValidation = testedString.MustBeEmail(false);
            Assert.IsTrue(returnedValidation);

            testedString = "mu5t.b3@email.sp.gov.br";
            returnedValidation = testedString.MustBeEmail(false);
            Assert.IsTrue(returnedValidation);

            testedString = "a b c d e";
            returnedValidation = testedString.IsWellFormatted(@"^[a-z ]+$", false);
            Assert.IsTrue(returnedValidation);

            testedString = Guid.NewGuid().ToString();
            returnedValidation = testedString.MustBeGuid(false);
            Assert.IsTrue(returnedValidation);

            testedString = new Guid().ToString();
            returnedValidation = testedString.MustBeGuid(false);
            Assert.IsTrue(returnedValidation);

            testedString = "Two words";
            returnedValidation = testedString.HasAtLeastWords(2, false);
            Assert.IsTrue(returnedValidation);

            testedString = "Five words at least to pass";
            returnedValidation = testedString.HasAtLeastWords(5, false);
            Assert.IsTrue(returnedValidation);

            testedString = "Five words to pass test";
            returnedValidation = testedString.HasAtLeastWords(5, false);
            Assert.IsTrue(returnedValidation);

            testedString = "One";
            returnedValidation = testedString.HasAtLeastWords(1, false);
            Assert.IsTrue(returnedValidation);

            testedString = "This string must be safe";
            returnedValidation = testedString.MustBeSafe(false);
            Assert.IsTrue(returnedValidation);

            testedString = "dots . and ! and ? and , and ; -";
            returnedValidation = testedString.MustBeSafe(false);
            Assert.IsTrue(returnedValidation);
        }

        [TestMethod]
        public void MustNot_ValidateString()
        {
            string testedString = "";
            var returnedValidation = testedString.MustHasValue(false);
            Assert.IsFalse(returnedValidation);

            testedString = " ";
            returnedValidation = testedString.MustHasValue(false);
            Assert.IsFalse(returnedValidation);

            testedString = string.Empty;
            returnedValidation = testedString.MustHasValue(false);
            Assert.IsFalse(returnedValidation);

            testedString = "This string must be greater than 40";
            returnedValidation = testedString.MustBeGreaterThan(40, false);
            Assert.IsFalse(returnedValidation);

            testedString = "This string must not be smaller than 50 characters....";
            returnedValidation = testedString.MustBeSmallerThan(50, false);
            Assert.IsFalse(returnedValidation);

            testedString = "a";
            returnedValidation = testedString.MustBeSmallerThan(1, false);
            Assert.IsFalse(returnedValidation);

            testedString = "This";
            returnedValidation = testedString.MustBeExactLength(5, false);
            Assert.IsFalse(returnedValidation);

            testedString = "This";
            returnedValidation = testedString.MustBeExactLength(3, false);
            Assert.IsFalse(returnedValidation);

            testedString = "Th1s str1ng must contains only l3tt3rs";
            returnedValidation = testedString.MustBeAlphabetic(false);
            Assert.IsFalse(returnedValidation);

            testedString = "Ç|";
            returnedValidation = testedString.MustBeAlphabetic(false);
            Assert.IsFalse(returnedValidation);

            testedString = "";
            returnedValidation = testedString.MustBeAlphabetic(false);
            Assert.IsFalse(returnedValidation);

            testedString = "1";
            returnedValidation = testedString.MustBeAlphabetic(false);
            Assert.IsFalse(returnedValidation);

            testedString = " ";
            returnedValidation = testedString.MustBeAlphabetic(false);
            Assert.IsFalse(returnedValidation);

            testedString = "1A2B3C";
            returnedValidation = testedString.MustBeNumeric(false);
            Assert.IsFalse(returnedValidation);

            testedString = "1,0";
            returnedValidation = testedString.MustBeNumeric(false);
            Assert.IsFalse(returnedValidation);

            testedString = "12345-@";
            returnedValidation = testedString.MustBeAlphanumeric(false);
            Assert.IsFalse(returnedValidation);

            testedString = "12345`çÇ";
            returnedValidation = testedString.MustBeAlphanumeric(false);
            Assert.IsFalse(returnedValidation);

            testedString = "This string must not contains a special character";
            returnedValidation = testedString.MustContainSpecialCharacters(false);
            Assert.IsFalse(returnedValidation);

            testedString = "ABC123Ç";
            returnedValidation = testedString.MustContainSpecialCharacters(false);
            Assert.IsFalse(returnedValidation);

            testedString = "mustbe@email@xpto.com";
            returnedValidation = testedString.MustBeEmail(false);
            Assert.IsFalse(returnedValidation);

            testedString = "mustbe@email";
            returnedValidation = testedString.MustBeEmail(false);
            Assert.IsFalse(returnedValidation);

            testedString = "mustbe..@email.com";
            returnedValidation = testedString.MustBeEmail(false);
            Assert.IsFalse(returnedValidation);

            testedString = "mustbe.@email.com";
            returnedValidation = testedString.MustBeEmail(false);
            Assert.IsFalse(returnedValidation);

            testedString = "mustbe_@email.com";
            returnedValidation = testedString.MustBeEmail(false);
            Assert.IsFalse(returnedValidation);

            testedString = "_mustbe@email.com";
            returnedValidation = testedString.MustBeEmail(false);
            Assert.IsFalse(returnedValidation);

            testedString = "- ";
            returnedValidation = testedString.IsWellFormatted(@"^[-]+$", false);
            Assert.IsFalse(returnedValidation);

            testedString = Guid.NewGuid().ToString().Replace('-', ' ');
            returnedValidation = testedString.MustBeGuid(false);
            Assert.IsFalse(returnedValidation);

            testedString = "Solo";
            returnedValidation = testedString.HasAtLeastWords(2, false);
            Assert.IsFalse(returnedValidation);

            testedString = "  ";
            returnedValidation = testedString.HasAtLeastWords(2, false);
            Assert.IsFalse(returnedValidation);

            testedString = "  a  ";
            returnedValidation = testedString.HasAtLeastWords(2, false);
            Assert.IsFalse(returnedValidation);

            testedString = "ax ";
            returnedValidation = testedString.HasAtLeastWords(2, false);
            Assert.IsFalse(returnedValidation);

            testedString = "<This is string must not be safe/>";
            returnedValidation = testedString.MustBeSafe(false);
            Assert.IsFalse(returnedValidation);
        }
    }
}
