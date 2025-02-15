class DivideConquer {
    public static void main(String[] args) {

        int[] array = {38, 27, 43, 3, 9, 10, 82};
            mergeSort(array, 0, array.length - 1);

        for (int i = 0; i < array.length; i++) 
            System.out.print(array[i] + " ");
    }

    static void mergeSort(int[] array, int left, int right) {

        if (left < right) {
            int mid = (left + right) / 2;
            mergeSort(array, left, mid);
            mergeSort(array, mid + 1, right);
            merge(array, left, mid, right); 
        }
    }

    static void merge(int[] array, int left, int mid, int right) { 
        int n1 = mid - left + 1;
        int n2 = right - mid; 

        int[] leftArray = new int[n1];
        int[] rightArray = new int[n2];

        for (int i = 0; i < n1; i++)
            leftArray[i] = array[left + i]; // + i not + 1

        for (int j = 0; j < n2; j++) 
            rightArray[j] = array[mid + 1 + j]; 

        int iIndex = 0, jIndex = 0, kIndex = left;

        while (iIndex < n1 && jIndex < n2) { // < n2 not = 0

            if (leftArray[iIndex] <= rightArray[jIndex]) 
                array[kIndex++] = leftArray[iIndex++];
            else 
                array[kIndex++] = rightArray[jIndex++];
        }
        // leftArray/rightArray place smaller to higher element
        while (iIndex < n1) 
            array[kIndex++] = leftArray[iIndex++];

        while (jIndex < n2) 
            array[kIndex++] = rightArray[jIndex++];
    }
}
