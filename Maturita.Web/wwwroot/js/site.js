const spacer = document.querySelector('.spacer');

setTimeout(RevealSpacer, 10);

function RevealSpacer() {
    spacer.classList.remove('hidden-spacer');
}