namespace Wing.Calculator.Tests

open NUnit.Framework
open FsUnit
open Wing.Brain.Brain

module module1 =
    
    [<TestFixture>]
    type ``Calculate Tests`` ()=

        let WorkOnList x = List.map (fun (x) -> x.ToString()) x;
        let lame x = List.head x;
           
        [<Test>] member test.
            Stack()=
                StackContents [] |> should equal (StackContents []);
                StackContents [1.0;2.0;3.0;] |> should equal (StackContents [1.0;2.0;3.0;]);
                push 1.0 (StackContents []) |> should equal (StackContents [1.0]);
                push 1.0 (StackContents [2.0]) |> should equal (StackContents [1.0;2.0]);

        [<Test>] member test.
         Square ()=
            Square 5 |> should equal 25;
            Square 0 |> should equal 0;
            Square 1.5 |> should equal 2.25;
            WorkOnList [1;2;3;4;5] |> should equal ["1";"2";"3";"4";"5"]

        [<Test>] member test.
          Add () = 
            Add 0 0 |> should equal 0;
            Add 0 1 |> should equal 1;
            Add 1 1 |> should equal 2;
            Add 2 1 |> should equal 3;
            Add 1 2 |> should equal 3;