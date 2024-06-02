public class Node {
    public int Data { get; set; }
    public Node? Right { get; private set; }
    public Node? Left { get; private set; }

    public Node(int data) {
        this.Data = data;
    }

    public void Insert(int value) {
        if (value ==Data){
            //this is the funniest solution
        }
        else if (value < Data) {
            // Insert to the left
            if (Left is null)
                Left = new Node(value);
            else
                Left.Insert(value);
        }
        else {
            // Insert to the right
            if (Right is null)
                Right = new Node(value);
            else
                Right.Insert(value);
        }
    }

    public bool Contains(int value) {
        // TODO Start Problem 2
        if (value==Data){
            return true;
        }else if (Right is null && Left is null){
            return false;
        }    
        else if(value<Data ){
            if (Left is not null){
                return Left.Contains(value);
            } else{return false;}
        }else if (value> Data){
            if (Right is not null){
                return Right.Contains(value);
            } else{return false;}
        }else{
            return false;
        }
    }

    public int GetHeight() {
        // TODO Start Problem 4
        if (this is null){
            return 0;
        }
        int leftCount =(Left is not null)? Left.GetHeight(): 0;
        int rightCount =(Right is not null)? Right.GetHeight(): 0; //gameplan. loop through, for each branch. when a branch ends. return value
        if (leftCount > rightCount)
            return leftCount+1;
        else{
            return rightCount+1;
        }
    }
}