const headers = document.querySelectorAll('.display-2');

const mainHeader = document.querySelector('.display-1');

const mainContent = document.createElement('div');
const listHeaders = document.createElement('ul');

mainHeader.classList.add('mb-0');
listHeaders.classList.add('content-header-list');


headers.forEach(x => {
    x.id = x.innerText;
    var liElement = document.createElement('li');
    var aElement = document.createElement('a');

    aElement.href = '#' + x.innerText;
    aElement.innerText = x.innerText;

    liElement.appendChild(aElement);
    listHeaders.appendChild(liElement);

    }
);

mainContent.appendChild(listHeaders);

mainHeader.insertAdjacentElement('afterend', mainContent);


