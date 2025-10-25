// EduVerse Interactive Features

// Smooth scrolling for anchor links
document.querySelectorAll('a[href^="#"]').forEach(anchor => {
    anchor.addEventListener('click', function (e) {
        e.preventDefault();
        const target = document.querySelector(this.getAttribute('href'));
        if (target) {
            target.scrollIntoView({
                behavior: 'smooth',
                block: 'start'
            });
        }
    });
});

// Navbar scroll effect
window.addEventListener('scroll', function() {
    const navbar = document.querySelector('.navbar');
    if (window.scrollY > 50) {
        navbar.style.background = 'rgba(15, 23, 42, 0.98)';
        navbar.style.boxShadow = '0 2px 20px rgba(0, 0, 0, 0.1)';
    } else {
        navbar.style.background = 'rgba(15, 23, 42, 0.95)';
        navbar.style.boxShadow = 'none';
    }
});

// Animate elements on scroll
const observerOptions = {
    threshold: 0.1,
    rootMargin: '0px 0px -50px 0px'
};

const observer = new IntersectionObserver(function(entries) {
    entries.forEach(entry => {
        if (entry.isIntersecting) {
            entry.target.style.opacity = '1';
            entry.target.style.transform = 'translateY(0)';
        }
    });
}, observerOptions);

// Observe all fade-in-up elements
document.querySelectorAll('.fade-in-up').forEach(el => {
    el.style.opacity = '0';
    el.style.transform = 'translateY(30px)';
    el.style.transition = 'opacity 0.6s ease-out, transform 0.6s ease-out';
    observer.observe(el);
});

// Course card hover effects
document.querySelectorAll('.course-card').forEach(card => {
    card.addEventListener('mouseenter', function() {
        this.style.transform = 'translateY(-10px)';
    });
    
    card.addEventListener('mouseleave', function() {
        this.style.transform = 'translateY(0)';
    });
});

// Form validation and submission
document.querySelectorAll('form').forEach(form => {
    form.addEventListener('submit', function(e) {
        const submitBtn = this.querySelector('button[type="submit"]');
        if (submitBtn) {
            submitBtn.innerHTML = '<span class="loading"></span> Processing...';
            submitBtn.disabled = true;
            
            // Re-enable after 2 seconds (for demo)
            setTimeout(() => {
                submitBtn.innerHTML = submitBtn.getAttribute('data-original-text') || 'Submit';
                submitBtn.disabled = false;
            }, 2000);
        }
    });
});

// Store original button text
document.querySelectorAll('button[type="submit"]').forEach(btn => {
    btn.setAttribute('data-original-text', btn.innerHTML);
});

// Search functionality
const searchInput = document.querySelector('input[placeholder="Search courses..."]');
if (searchInput) {
    searchInput.addEventListener('input', function() {
        const searchTerm = this.value.toLowerCase();
        const courseCards = document.querySelectorAll('.course-card');
        
        courseCards.forEach(card => {
            const title = card.querySelector('h5').textContent.toLowerCase();
            const description = card.querySelector('p').textContent.toLowerCase();
            
            if (title.includes(searchTerm) || description.includes(searchTerm)) {
                card.parentElement.style.display = 'block';
            } else {
                card.parentElement.style.display = 'none';
            }
        });
    });
}

// Progress bar animation
document.querySelectorAll('.progress-bar').forEach(bar => {
    const width = bar.style.width;
    bar.style.width = '0';
    
    setTimeout(() => {
        bar.style.transition = 'width 1s ease-in-out';
        bar.style.width = width;
    }, 500);
});

console.log('EduVerse platform loaded successfully! 🎓');