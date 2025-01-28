//Image preview in Gallery
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

//Event preview
function openEventPreview(element) {

    // Extract event details from data-* attributes
    const currentEvent = {
        Title: element.dataset.title,
        Description: element.dataset.description,
        Date: element.dataset.date,
        Location: element.dataset.location,
        Venue: element.dataset.venue,
        StartTime: element.dataset.start,
        EndTime: element.dataset.end,
    };

    // Debug to ensure the object is correct
    console.log(currentEvent.Title);

    // Populate the modal with event details
    document.getElementById('eventModalLabel').textContent = currentEvent.Title;
    document.getElementById('eventDescription').textContent = currentEvent.Description;
    document.getElementById('eventDate').textContent = currentEvent.Date;
    document.getElementById('eventLocation').textContent = currentEvent.Location;
    document.getElementById('eventVenue').textContent = currentEvent.Venue;
    document.getElementById('eventTime').textContent = `${currentEvent.StartTime} - ${currentEvent.EndTime}`;
}