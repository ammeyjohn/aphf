<style>
    .content1 {
        width: 500px;
        height: 500px;
        background-image: url('img/img1.jpg');
    }

    .content2 {
        width: 500px;
        height: 500px;
        background-image: url('img/img2.jpg');
    }

    .content3 {
        width: 500px;
        height: 500px;
        background-image: url('img/img3.jpg');
    }
</style>

<template>
    <div class="page-slider margin-bottom-40">
        <div class="owl-carousel owl-theme">
            <div class="content1">
            </div>
            <div class="content2"> Your Content </div>
            <div class="content3"> Your Content </div>
            <div class="content2"> Your Content </div>
            <div class="content3"> Your Content </div>
            <div class="content1"> Your Content </div>
            <div class="content2"> Your Content </div>
        </div>
    </div>
</template>

<script>
    import 'owl.carousel/dist/assets/owl.carousel.css';
    import 'owl.carousel/dist/assets/owl.theme.default.css';
    import 'owl.carousel/dist/owl.carousel.js';

    export default {
        mounted() {
            $(".owl-carousel").owlCarousel({
                loop: true,
                margin: 5,
                center: true,
                autoWidth: true,
                autoplay: true,
                autoplayTimeout: 5000,
                autoplayHoverPause: true,
                merge: true,
                responsive: {
                    678: {
                        mergeFit: true
                    },
                    1000: {
                        mergeFit: false
                    }
                }
            });
        }
    }
</script>