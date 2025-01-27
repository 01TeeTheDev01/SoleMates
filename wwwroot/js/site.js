document.addEventListener('DOMContentLoaded', () => {
    const previewModal = document.getElementById('imagePreviewModal');
    const previewImage = document.getElementById('previewImage');
    const body = document.body;

    // Attach event listener for each preview image
    document.querySelectorAll('.preview-image').forEach(img => {
        img.addEventListener('click', function () {
            const imageSrc = this.getAttribute('data-src');
            previewImage.src = imageSrc;
            //body.style.opacity = "0.5"; 
            previewImage.style.opacity = "1"; // Ensure the image has full opacity
        });
    });

    previewModal.addEventListener('hidden.bs.modal', () => {
        body.style.opacity = "1"; // Restore normal opacity
        previewImage.src = ""; // Clear the image source when modal closes
    });
});