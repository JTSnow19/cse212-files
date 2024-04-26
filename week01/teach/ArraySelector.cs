public static class ArraySelector
{
    public static void Run()
    {
        var l1 = new[] { 1, 2, 3, 4, 5 };
        var l2 = new[] { 2, 4, 6, 8, 10};
        var select = new[] { 1, 1, 1, 2, 2, 1, 2, 2, 2, 1};
        var intResult = ListSelector(l1, l2, select);
        Console.WriteLine("<int[]>{" + string.Join(", ", intResult) + "}"); // <int[]>{1, 2, 3, 2, 4, 4, 6, 8, 10, 5}
    }

    private static int[] ListSelector(int[] list1, int[] list2, int[] select)
    {
        int count = 0;
        List<int> selectedItems = new List<int>();
        int l1C =0;
        int l2C =0;
        do{
            if (select[count] ==1){
                selectedItems.Add(list1[l1C]);
                l1C++;
            }
            else{
                selectedItems.Add(list2[l2C]);
                l2C++;
            }
            count++;
        } while(count!= select.Count());
        //I found the ugliest solution!!@!!!! probably an easy way to clean this up but I wanted to get it done fast
        var staticList = new int[10]{selectedItems[0],selectedItems[1],selectedItems[2],selectedItems[3],selectedItems[4],selectedItems[5],selectedItems[6],selectedItems[7],selectedItems[8],selectedItems[9]};
        return staticList;
    }
}