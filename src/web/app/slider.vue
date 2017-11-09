<style>
    .owl-carousel {
        width: 100%;
        height: 500px;
        margin-top: -25px;
        margin-bottom: 40px;
    }
    .owl-stage-outer {
        width: 100%;
        z-index: -1;
    }
    .owl-dots {
        margin-top: -30px !important;
    }
    .owl-carousel .slider {
        width: 100%;
        height: 500px;
    }
    .owl-carousel .slider img {
        width: 100%;
    }
    .owl-carousel .slider .caption {
        color: white;
        width: 960px;
        margin-left: -480px;
        height: 100px;
        padding: 20px;
        position: absolute;
        top: 300px;
        left: 50%;
        z-index: 120;
    }
    .owl-carousel .slider .caption .title {
        font-weight:bold;
        color:#FFF;
        background: rgba(0, 0, 0, 0.3);
        font-size:24px;
        position:absolute;
        top:20px;
        left:20px;
        z-index:30;
        padding:5px 10px;
        opacity: 1;        
    }    
    .owl-carousel .slider .caption .desc {
        font-weight:bold;
        color:#FFF;
        background: rgba(0, 0, 0, 0.3);
        font-size:16px;
        position:absolute;
        width: 700px;
        top:70px;
        left:20px;
        z-index:40;
        padding:5px 10px;
        opacity:1;        
    }
    .owl-carousel .owl-item.active .title {
        -moz-animation: bounceInUp .5s ease-in .3s  backwards;
        -webkit-animation: bounceInUp  .5s ease-in .3s backwards;
        animation: bounceInUp .5s ease-in .3s  backwards;
    }
    .owl-carousel .owl-item.active .desc {
        -moz-animation: bounceInUp .5s ease-in .5s  backwards ;
        -webkit-animation: bounceInDown .5s ease-in .5s  backwards;
        animation: bounceInUp .5s ease-in .5s  backwards;
    } 
    .dots {
        margin-top: -30px;
    }   
</style>

<template>    
    <div class="owl-carousel owl-theme">
        <div class="slider">
            <img src="assets/images/slider/AikangFu-1000x500.jpg">
            <div class="caption">
                <div class="title">FunStage: ‘FLASHMOB’快闪活动</div>
                <div class="desc">See Prize Giving Ceremony of 9th Asia Pacific Harmonica Festival Harmonica Competition 游览第九届 亚太口琴节颁奖典礼 Harmonica Competition Results 口琴比赛成绩: 複音口琴獨奏(一般)新秀...</div>
            </div>
        </div>
        <div class="slider">
            <img src="assets/images/slider/closingcere-1000x500.jpg">
            <div class="caption">
                <div class="title">FunStage: ‘FLASHMOB’快闪活动</div>
                <div class="desc">See Prize Giving Ceremony of 9th Asia Pacific Harmonica Festival Harmonica Competition 游览第九届 亚太口琴节颁奖典礼 Harmonica Competition Results 口琴比赛成绩: 複音口琴獨奏(一般)新秀...</div>
            </div>            
        </div>
        <div class="slider">
            <img src="assets/images/slider/Compe-1000x500.jpg">
            <div class="caption">
                <div class="title">FunStage: ‘FLASHMOB’快闪活动</div>
                <div class="desc">See Prize Giving Ceremony of 9th Asia Pacific Harmonica Festival Harmonica Competition 游览第九届 亚太口琴节颁奖典礼 Harmonica Competition Results 口琴比赛成绩: 複音口琴獨奏(一般)新秀...</div>
            </div>             
        </div>
        <div class="slider">
            <img src="assets/images/slider/Forum-1000x500.jpg">
            <div class="caption">
                <div class="title">FunStage: ‘FLASHMOB’快闪活动</div>
                <div class="desc">See Prize Giving Ceremony of 9th Asia Pacific Harmonica Festival Harmonica Competition 游览第九届 亚太口琴节颁奖典礼 Harmonica Competition Results 口琴比赛成绩: 複音口琴獨奏(一般)新秀...</div>
            </div>             
        </div>
        <div class="slider">
            <img src="assets/images/slider/FunStagee-1000x500.jpg">
            <div class="caption">
                <div class="title">FunStage: ‘FLASHMOB’快闪活动</div>
                <div class="desc">See Prize Giving Ceremony of 9th Asia Pacific Harmonica Festival Harmonica Competition 游览第九届 亚太口琴节颁奖典礼 Harmonica Competition Results 口琴比赛成绩: 複音口琴獨奏(一般)新秀...</div>
            </div>             
        </div>
        <div class="slider">
            <img src="assets/images/slider/GrandTalent1-1000x500.jpg">
            <div class="caption">
                <div class="title">FunStage: ‘FLASHMOB’快闪活动</div>
                <div class="desc">See Prize Giving Ceremony of 9th Asia Pacific Harmonica Festival Harmonica Competition 游览第九届 亚太口琴节颁奖典礼 Harmonica Competition Results 口琴比赛成绩: 複音口琴獨奏(一般)新秀...</div>
            </div>             
        </div>
        <div class="slider">
            <img src="assets/images/slider/Jammin1-1000x500.jpg">
            <div class="caption">
                <div class="title">FunStage: ‘FLASHMOB’快闪活动</div>
                <div class="desc">See Prize Giving Ceremony of 9th Asia Pacific Harmonica Festival Harmonica Competition 游览第九届 亚太口琴节颁奖典礼 Harmonica Competition Results 口琴比赛成绩: 複音口琴獨奏(一般)新秀...</div>
            </div>             
        </div>
        <div class="slider">
            <img src="assets/images/slider/Maestro11-1000x500.jpg">
            <div class="caption">
                <div class="title">FunStage: ‘FLASHMOB’快闪活动</div>
                <div class="desc">See Prize Giving Ceremony of 9th Asia Pacific Harmonica Festival Harmonica Competition 游览第九届 亚太口琴节颁奖典礼 Harmonica Competition Results 口琴比赛成绩: 複音口琴獨奏(一般)新秀...</div>
            </div>             
        </div>        
    </div>
</template>

<script>
    import 'animate.css';
    import 'owl.carousel/dist/assets/owl.carousel.css';
    import 'owl.carousel/dist/assets/owl.theme.default.css';
    import 'owl.carousel/dist/owl.carousel.js';

    export default {
        mounted() {
            $(".owl-carousel").owlCarousel({
                items: 1,
                loop: true,
                center: true,                
                autoplay: true,
                autoplayTimeout: 5000,
                autoplayHoverPause: true
            });
        }
    }
</script>