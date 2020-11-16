using System;
using Xunit;
using CommandAPI.Models;

namespace CommandAPI.Tests
{
    public class CommandTests : IDisposable
    {
        Command testCommand;

        public CommandTests()
        {
            testCommand = new Command
            {
                HowTo = "Do something",
                Platform = "Some Platform",
                CommandLine = "Some commandline"
            };
        }

        public void Dispose()
        {
            testCommand = null;
        }

        [Fact]
        public void CanChangeHowTo()
        {
            // Arrange

            // Act
            testCommand.HowTo = "Execute Unit tests";

            // Assert
            Assert.Equal("Execute Unit tests", testCommand.HowTo);
        }

        [Fact]
        public void CanChangePlatform()
        {
            // Arrange

            // Act
            testCommand.Platform = "Execute Unit tests";

            // Assert
            Assert.Equal("Execute Unit tests", testCommand.Platform);
        }

        [Fact]
        public void CanChangeCommandLine()
        {
            // Arrange

            // Act
            testCommand.CommandLine = "Execute Unit tests";

            // Assert
            Assert.Equal("Execute Unit tests", testCommand.CommandLine);
        }


    }
}
