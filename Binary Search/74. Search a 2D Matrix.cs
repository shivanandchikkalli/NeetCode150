public class Solution {
    public bool SearchMatrix(int[][] matrix, int target) {
        // Find row
        int rowIdx = 0;

        int left = 0;
        int right = matrix.Length - 1;
        int mid = (right + left) / 2;

        if (matrix.Length > 1)
        {
            while (left <= right)
            {
                if (target == matrix[mid][0])
                    return true;
                else if (target > matrix[mid][0])
                    left = mid + 1;
                else if (target < matrix[mid][0])
                    right = mid - 1;
                
                mid = (right + left) / 2;
            }
        }
        rowIdx = right;
        if (rowIdx < 0)
            return false;
            
        // check if it exists
        left = 0;
        right = matrix[rowIdx].Length - 1;
        mid = (right + left) / 2;

        while (left <= right)
        {
            if (target == matrix[rowIdx][mid])
                return true;
            else if (target > matrix[rowIdx][mid])
                left = mid + 1;
            else if (target < matrix[rowIdx][mid])
                right = mid - 1;

            mid = (right + left) / 2;
        }

        return false;        
    }
}