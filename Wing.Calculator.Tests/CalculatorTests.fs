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
         Square ()=
            Square 5 |> should equal 25;
            Square 0 |> should equal 0;
            Square 1.5 |> should equal 2.25;
            WorkOnList [1;2;3;4;5] |> should equal ["1";"2";"3";"4";"5"]

        [<Test>] member test.
          Add () = 
            Add 0 0 |> should equal 0