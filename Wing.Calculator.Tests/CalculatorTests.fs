namespace Wing.Calculator.Tests

open NUnit.Framework
open FsUnit
open Wing.Brain.Brain

module module1 =
    
    [<TestFixture>]
    type ``Stack Tests`` ()=

        let WorkOnList x = List.map (fun (x) -> x.ToString()) x;
        let lame x = List.head x;
           
        [<Test>] member test.
            ``Stackcontents can create an empty stack``()=
                StackContents [] |> should equal (StackContents []);
        
        [<Test>] member test.
            ``Stackcontents can create a stack with values``()=
                StackContents [1.0;2.0;3.0;] |> should equal (StackContents [1.0;2.0;3.0;]);
        [<Test>] member test.
            ``We can push a float into an empty stack content to give a stackcontent with one float``()=
                push 1.0 (StackContents []) |> should equal (StackContents [1.0]);
        [<Test>] member test.
            ``We can push a float into a stack content with values to give a stackcontent with the same values and one float at the head``()=
                push 1.0 (StackContents [2.0]) |> should equal (StackContents [1.0;2.0]);
//                pop (StackContents []) |> ignore |> should throw typeof<Wing.Brain.Brain.StackOverflowException>
        [<Test>] member test.
                ``We can pop a float from a stack content with values to give a stackcontent with the same values minus one float at the head``()=
                  pop (StackContents [2.0; 1.0]) |> should equal (2.0, StackContents [1.0]);
                  pop (StackContents [2.0]) |> should equal (2.0, StackContents List.empty<float>);

        [<Test>] member test.
            Eval()=
               Eval (StackContents [1.0;])( StackContents []) |> should equal 1.0;
               Eval (StackContents [5.0;])( StackContents []) |> should equal 5.0;
               Eval (StackContents [5.0;1.0;])( StackContents [Op Plus]) |> should equal 6.0;
               Eval (StackContents [])( StackContents [Num 2.0; Num 1.0; Op Plus]) |> should equal 3.0;