class DivideConquer {
    public static void main(String[] args) {
        
        int[]array = {38,27,43,3,9,82};
          MergeSort(array, 0, array.length - 1);
            printArray(array);
   }
       
       Static void MergeSort(int[]array, int left, int right) {
            
            if(left < right) {
                  int mid (left + right) / 2;
                  MergeSort(array, left, mid);
                  MergeSort(array, mid + 1, right);
                  MergeSort(array, left, mid, right);
            
   }
       
       Static void Merge(int[]array, int left, int right) {
            
            int n1 = mid - left + 1;
            int n2 = rifht - mid;
            int leftArray = new int [n1];
            int rightArray = new int [n2];
            
          for(int i = 0; i < n1; i++)
               leftArray[i] = array[left + i];
          
          for(int j = 0; j < n1; i++)
              righttArray[j] = array[mid + 1 + j];
              
            int iIndex = 0, jIndex = 0, kIndex = left;
          
          while(iIndex < n1 && jIndex < n2) {
                  
                  if(leftArray[iIndex] <= right[jIndex]) array[kIndex++] = leftArray[iIndex++];
                  
                  else
                     array[kIndex++] = rightArray[jIndex++];           
     }
        static void printArray(int[] array) {
               for (int i = 0; i < array.length; i++) {
                System.out.print(array[i] + " ");
        }
        System.out.println();
     }
     
    }
}
