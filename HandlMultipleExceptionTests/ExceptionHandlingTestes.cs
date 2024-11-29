using Handling_Multiple__Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandlingTests
{
    public class ExceptionHandlingTestes
    {
        private HandlingMultiException _exceptionHandler;
        private string _input;
        private int _index;

        // Konstruktorn 
        public ExceptionHandlingTestes()
        {
            _exceptionHandler = new HandlingMultiException();
            _input = "1";
            _index = 1;
        }

        [Fact]
        public void HandleMultipleExceptions_validIndexAndInput_ReturnsArrayElemnent()
        {
            // Act
            string result = _exceptionHandler.HandleMultipleExceptions(_input, _index);

            // Assert
            Assert.Equal("2", result); // index 1 i arrayen ger värdet 2 ({1, 2, 3})
        }

        [Fact]
        public void HandleMultipleExceptions_InvalidFormat_ReturnsInvalidFormatMessage()
        {

            _input = "abc";  // Ogiltigt tal

            // Act
            string result = _exceptionHandler.HandleMultipleExceptions(_input, _index);

            // Assert
            Assert.Equal("Invalid format.", result);
        }

        [Fact]
        public void HandleMultipleExceptions_IndexOutOfRange_ReturnsIndexOutOfRangeMessage()
        {

            _index = 5;  // Index utanför arrayens gränser

            // Act
            string result = _exceptionHandler.HandleMultipleExceptions(_input, _index);

            // Assert
            Assert.Equal("Index out of range.", result);
        }
    }
}

