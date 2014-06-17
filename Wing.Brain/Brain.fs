namespace Wing.Brain

module Brain =

    exception StackOverflowException of string
    
    type Stack = StackContents of float list
    let EMPTY = StackContents []
    
    let push x stack =
        let (StackContents contents) = stack
        let newContents = x::contents
        (StackContents newContents)

    let pop (StackContents contents) =
        match contents with 
            | x::xs -> x , (StackContents xs)
            | [] -> 
                raise (StackOverflowException("stack overflow"))
        
    let Eval results EMPTY = 
        let (res, remainder) = pop results
        res
            
    

