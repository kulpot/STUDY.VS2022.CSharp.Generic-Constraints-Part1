using System;
using System.Collections;

//ref link:https://www.youtube.com/watch?v=aGvmqtfFjOw&list=PLRwVmtr-pp05ETzLYQ8kv1cI5v9ddT8er&index=11
// 

class ClassOne { public ClassOne() { } } // parameter list constructor
//class ClassTwo { public ClassTwo(int i, char c) { } } // no parameter list constructor
class ClassTwo : ClassOne { public ClassTwo() { } } // inherits class one
class ClassThree : ClassOne { public ClassThree() { } } // inherits class one


class MainClass
{
    static T ProduceA<T>() where T : ClassOne, new()
    {
        T returnVal = new T();
        return returnVal;
    }
    static void Main()
    {
        ProduceA<ClassOne>();
        ProduceA<ClassTwo>();
        ProduceA<ClassThree>();
    }
}