const spacer = document.querySelector('.spacer');

setTimeout(RevealSpacer, 10);

function RevealSpacer() {
    spacer.classList.remove('hidden-spacer');
}

const disabledLinks = document.querySelectorAll('[Disabled]');

disabledLinks.forEach(x => x.removeAttribute('href'));