namespace Wing.Brain

module Brain =

    exception StackOverflowException of string
    exception UnknownTokenException of string
//    type StackContents<'T> = 'T list
    type Stack<'T> = StackContents of 'T list
//    type InputStack = StackContents of string list
    type inputs = 
        | Num of float 
        | Op of string
    
    let EMPTY = StackContents []
//        
    let push x stack =
        let (StackContents contents) = stack
        let newContents = x::contents
        (StackContents newContents)
//
    let pop (StackContents contents) =
        match contents with 
            | x::xs -> x , (StackContents xs)
            | [] -> 
                raise (StackOverflowException("stack overflow"))
//    
    let GetFinalResult results input = 
          let (res, remainder) = pop results
          res    
//        
    let EvalHelper results inputs =
        let (input, newInputs) = pop inputs
        match input with 
            | Op o -> let (left, newResults1) = pop results
                      let (right, newResults2) = pop newResults1
                      (push (left + right) newResults2), newInputs
            | Num x -> push (float x) results, newInputs
            | _ ->               
                raise (System.Exception("Unknown input"))

    let rec Eval results inputs = 
        match inputs with 
            | StackContents [] -> GetFinalResult results inputs
            | _ -> let (newResults , newInput) = EvalHelper results inputs
                   Eval newResults newInput 
        

//    
//
