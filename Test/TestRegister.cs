using Bussines;
using Xunit;

namespace Test
{
    public class TestRegister
    {
        [Fact]
        public void Email_is_correct()
        {
            var reg = new RegisterUser();

            var email = "prueba@gmail.com";

            Assert.True(reg.Register(email, "1234567890", "1234567890"));
        }

        [Fact]
        public void Email_invalid_should_return_false()
        {
            var reg = new RegisterUser();
            var email = "pepe";

            Assert.False(reg.Register(email, "1234567890", "1234567890"));
        }

        [Fact]
        public void Password_should_be_10_caracter()
        {
            var reg = new RegisterUser();
            var pass = "1234567890";
            Assert.True(reg.Register("a@a.c", pass, pass));
        }

        [Fact]
        public void Password_less_10_caracter_should_return_false()
        {
            var reg = new RegisterUser();
            var pass = "1";
            Assert.False(reg.Register("a@a.c", pass, pass));
        }

        [Fact]
        public void Password_is_different_pass2_should_return_false()
        {
            var reg = new RegisterUser();
            var pass = "12345678901";
            Assert.False(reg.Register("a@a.c", pass, "2"));
        }

    }
}
