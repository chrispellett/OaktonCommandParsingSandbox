using Oakton;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OaktonParserTest
{
    class MyCommand : OaktonCommand<MyInput>
    {
        public override bool Execute(MyInput input)
        {
            return true;
        }
    }
}
