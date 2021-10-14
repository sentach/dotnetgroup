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

            Assert.True(reg.Register(email, ""));
        }

        [Fact]
        public void Email_invalid_should_return_false()
        {
            var reg = new RegisterUser();
            var email = "pepe";

            Assert.False(reg.Register(email, ""));
        }
    }
}
