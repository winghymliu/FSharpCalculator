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
//                pop (StackContents []) |> ignore |> should throw typeof<Wing.Brain.Brain.StackOverflowException>
                pop (StackContents [2.0]) |> should equal (2.0, StackContents []);

        [<Test>] member test.
            Eval()=
               Eval (StackContents [1.0;])( StackContents []) |> should equal 1.0;