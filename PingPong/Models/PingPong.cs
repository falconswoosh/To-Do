using System;
using System.Collections.Generic;

namespace PingPongGenerator.Models
{
    public class PingPong
    {
        public string GetNumber(int number)
        {
          string output = "";
          if (number % 3 == 0)
          {
            output += "ping";
          }
          if (number % 5 == 0)
          {
            output += "pong";
          }
          return output;
        }
    }
}
