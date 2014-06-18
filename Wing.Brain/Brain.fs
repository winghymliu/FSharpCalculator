namespace Wing.Brain

module Brain =

    exception StackOverflowException of string
//    type StackContents<'T> = 'T list
    type Stack<'T> = StackContents of 'T list
//    type InputStack = StackContents of string list
    
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
//    let GetFinalResult results input = 
//          let (res, remainder) = pop results
//          res    
//        
//    let rec Eval results inputs = 
//        match inputs with 
//            | StackContents [] -> GetFinalResult results inputs
//            | _ -> let (newResults , newInput) = EvalHelper results inputs
//                   Eval newResults newInput 
//        
//    let EvalHelper results inputs =
//        let (input, newInputs) = pop inputs
//        match input with 
//            | "1.0" -> push 1.0 results
//            | "2.0" -> push 2.0 results
//            | "+" ->  (pop results + pop results)
//    
//
