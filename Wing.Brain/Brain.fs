namespace Wing.Brain

module Brain =

    type Stack = StackContents of float list

    let push x stack =
        let (StackContents contents) = stack
        let newContents = x::contents
        (StackContents newContents)
        
    let inline public Square x = x * x;

    let Add x y =
        x + y

