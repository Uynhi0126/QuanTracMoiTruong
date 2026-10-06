import cv2
import numpy as np

def fill_border(image, thickness=2, fill_value=0):
    M, N = image.shape[:2]
    result = image.copy()
    
    result[0:thickness, :] = fill_value
    result[M - thickness:M, :] = fill_value
    
    result[:, 0:thickness] = fill_value
    result[:, N - thickness:N] = fill_value
    return result

sample = np.full((6, 7), 255, dtype=np.uint8)
output = fill_border(sample, thickness=2, fill_value=0)

# Phóng to ảnh để dễ hiển thị
output_large = cv2.resize(output, (350, 300), interpolation=cv2.INTER_NEAREST)
output_large = cv2.cvtColor(output_large, cv2.COLOR_GRAY2BGR)

cv2.putText(output_large, "52400222", (10, 30), 
cv2.FONT_HERSHEY_SIMPLEX, 1, (0, 255, 0), 2)
cv2.imwrite("theory1_ex1.png", output_large)