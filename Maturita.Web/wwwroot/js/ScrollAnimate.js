const observer = new IntersectionObserver((entries) => {
    entries.forEach((entry) => {
        //console.log(entry);
        if (entry.isIntersecting) {
            entry.target.classList.add('show');
        } else {
            //entry.target.classList.remove('show');
        }
    });
});

const hiddenElements = document.querySelectorAll('.background-text');
hiddenElements.forEach((el) => observer.observe(el));


const hiddenElements2 = document.querySelectorAll('.hidden');
hiddenElements2.forEach((el) => observer.observe(el));


window.addEventListener('scroll', function () {
    const scrollPosition = window.scrollY;
    const triggerHeight = 300; 

    if (scrollPosition >= triggerHeight) {
        document.getElementById('GoUp').classList.remove('go-up-notActive');
    } else {
        document.getElementById('GoUp').classList.add('go-up-notActive');
    }
});