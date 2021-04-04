$(document).ready(function () {

    (function (e) {
        e.fn.circle = function (t) {
            var n = e.extend({
                speed: "5000"
            }, t);
            return this.each(function () {
                function t() {
                    var e = i.find("li.block.active").index();
                    c.removeClass("active"), c.eq(e).addClass("active")
                }

                function o() {
                    var n;
                    i.addClass("disable-hover"), i.stop(!0, !0).animate({
                        rotatedeg: p.deg += p.step
                    }, {
                        duration: 400,
                        step: function (t) {
                            t >= 360 ? t -= 360 : t <= -360 && (t += 360), e(this).css("transform", "rotate(" + t + "deg)"), e(this).css("-webkit-transform", "rotate(" + t + "deg)")
                        },
                        complete: function () {
                            p.active = i.find("li.active").removeClass("active"), "right" == p.direction && p.step == d && (p.active.prev() && p.active.prev().length ? (n = p.active.prev().index(), p.active.prev().addClass("active")) : (p.active.siblings(":last-child").addClass("active"), n = 9)), "left" == p.direction && p.step == u && (p.active.next() && p.active.next().length ? (n = p.active.next().index(), p.active.next().addClass("active")) : (p.active.siblings(":first-child").addClass("active"), n = 0)), i.is(":animated"), i.removeClass("disable-hover"), t()
                        }
                    }, "ease")
                }

                function r() {
                    i.addClass("disable-hover"), i.stop(!0, !0).animate({
                        rotatedeg: p.deg += p.step
                    }, {
                        duration: 400,
                        step: function (t) {
                            t >= 360 ? t -= 360 : t <= -360 && (t += 360), e(this).css("transform", "rotate(" + t + "deg)"), e(this).css("-webkit-transform", "rotate(" + t + "deg)")
                        },
                        complete: function () {
                            p.active = i.find("li.active"), i.is(":animated"), i.removeClass("disable-hover")
                        }
                    }, "ease")
                }
                var i = e(this),
                    s = i.find("li").length,
                    a = i.find(" > li .icon"),
                    l = "count" + s,
                    u = 0,
                    c = i.next().find(".animate"),
                    p = {
                        duration: n.speed,
                        deg: 0,
                        step: u,
                        active: i.find("li.active"),
                        direction: "left"
                    };
                switch (s) {
                    case 10:
                        u = -36;
                        break;
                    case 9:
                        u = -40;
                        break;
                    case 8:
                        u = -45;
                        break;
                    case 7:
                        u = -51.5;
                        break;
                    case 6:
                        u = -60;
                        break;
                    case 5:
                        u = -72;
                        break;
                    case 4:
                        u = -90;
                        break;
                    case 3:
                        u = -120;
                        break;
                    case 2:
                        u = -180;
                        break;
                    case 1:
                        u = -360
                }
                i.addClass(l);
                var d = u - 2 * u;
                i.find("> li").first().addClass("active"), i.find("> li").first().find("a").attr("href"), c.eq(0).addClass("active"), e(a).on("click", function () {
                    var n = e(this).parent().index() - i.find("li.active").index();
                    i.children("li").removeClass("active"), e(this).parent().addClass("active"), p.step = -n * d, n * d >= 288 && (p.step = -n * d + 360), n * d <= -288 && (p.step = -n * d - 360), r(), p.step = u, p.direction = "left", t()
                });
                var f = i.parent().find("div.next"),
                    h = i.parent().find("div.prev");
                f.on("click", function () {
                    i.is(":animated") || (p.direction = "left", p.step = u, o())
                }), h.on("click", function () {
                    i.is(":animated") || (p.direction = "right", p.step = d, o())
                })
            })
        }
    }(jQuery));


    $(function () {
        //Background image
        $('div').each(function () {
            var url = $(this).attr('data-image');
            if (url) {
                $(this).css('background-image', 'url(' + url + ')');
            }
        });

        $('section').each(function () {
            var url = $(this).attr('data-image');
            if (url) {
                $(this).css('background-image', 'url(' + url + ')');
            }
        });

        // Service Auto height circle 
        function autoHeightCircle() {
            var circle = $('.circle--rotate'),
                circleInner = $('.animate-wrapper'),
                circleH = circle.width(),
                circleInnerH = circleInner.width();
            circle.height(circleH);
            circleInner.height(circleInnerH);
        }

        $("#circle--rotate").circle();
        autoHeightCircle();
        $(window).resize(function () {
            autoHeightCircle();
        });
    });


    setTimeout(() => {
        $(".preloader").addClass("loaded")
    }, 1500);
    $("header .menu-bar").click(function () {
        $("header nav.menu").toggleClass("active")
        $("header").toggleClass("active")
        $("body").toggleClass("active")
    })
    $('#slider .owl-carousel').owlCarousel({
        loop:true,
        margin:0,
        nav:false,
        items: 1,
        dots: true
    })

    $("#slider .slider-right-side-aside .right-side-item").each(function(index, element){
        $("#slider .owl-dots button")[index].setAttribute("data-id", `${$(element).attr("data-id")}`)
        $(element).click(function () {
            $("#slider .owl-dots button.active").removeClass("active")
            let slider_item = $(`#slider .slider-item[data-id=${$(element).attr("data-id")}]`)[0]
            let width = $(slider_item).width()
            let data_id = parseInt($(element).attr("data-id"))
            $(`#slider .owl-dots button[data-id=${data_id}]`).addClass("active")
            $("#slider .owl-stage").css({
                "transform": `translate3d(-${width * (data_id + 1)}px, 0px, 0px)`,
                "transition": "all 0.25s ease 0s"
            })
        })
    })
    $("#services .next").click(function(){
        let data_id = parseInt($("#services .slide-wrapper .slide.active").attr("data-id"))

        if (parseInt($("#services .slide-wrapper .slide.active").attr("data-id")) == $("#services .slide-wrapper .slide").length) {
            $("#services .slide-wrapper .slide.active").removeClass("active").parent().children().first().addClass("active")
            data_id = parseInt($("#services .slide-wrapper .slide.active").attr("data-id"))
        }
        else{
            $("#services .slide-wrapper .slide.active").removeClass("active").next().addClass("active")
            data_id = parseInt($("#services .slide-wrapper .slide.active").attr("data-id"))
        }
        $("#services .pagination").css(
            {
                "transform": `translate(-50%, -50%) rotate(${-((data_id - 1) * 70)}deg)`
            }
        )
        $(`#services .pagination .item.active`).removeClass("active")
        $(`#services .pagination .item[data-id=${data_id}]`).addClass("active")
    })
    $("#services .prev").click(function(){
        let data_id = parseInt($("#services .slide-wrapper .slide.active").attr("data-id"))

        if (parseInt($("#services .slide-wrapper .slide.active").attr("data-id")) == 1) {
            $("#services .slide-wrapper .slide.active").removeClass("active").parent().children().last().addClass("active")
            data_id = parseInt($("#services .slide-wrapper .slide.active").attr("data-id"))

        }
        else{
            $("#services .slide-wrapper .slide.active").removeClass("active").prev().addClass("active")
            data_id = parseInt($("#services .slide-wrapper .slide.active").attr("data-id"))

        }
        $("#services .pagination").css(
            {
                "transform": `translate(-50%, -50%) rotate(${-((data_id - 1) * 70)}deg)`
            }
        )
        $(`#services .pagination .item.active`).removeClass("active")
        $(`#services .pagination .item[data-id=${data_id}]`).addClass("active")
    })
    $("#services .pagination .item").each(function (index, element) {
        $(element).css("transform", `rotate(${(index) * 70}deg)`)
    })
    $("#services .pagination .item").click(function(){
        let data_id = parseInt($(this).attr("data-id"))
        let transform = 0
        transform = transform - ((data_id - 1) * 70)
        $("#services .pagination .item.active").removeClass("active")
        $("#services .pagination").css(
            {
                "transform": `translate(-50%, -50%) rotate(${transform}deg)`
            }
        )
        $(this).addClass("active")
        $("#services .slide-wrapper .slide.active").removeClass("active")
        $(`#services .slide-wrapper .slide[data-id=${data_id}]`).addClass("active")
    })
    var $grid = $('#portfolio-page .filtered-items').isotope({
        itemSelector: '.filter-item',
        layoutMode: 'fitRows'
    });
    // filter functions
    var filterFns = {
        // show if number is greater than 50
        numberGreaterThan50: function() {
        var number = $(this).find('.number').text();
        return parseInt( number, 10 ) > 50;
        },
        // show if name ends with -ium
        ium: function() {
        var name = $(this).find('.name').text();
        return name.match( /ium$/ );
        }
    };
    // bind filter button click
    $('#portfolio-page .category-names').on( 'click', 'a', function(e) {
        e.preventDefault()
        var filterValue = $( this ).attr('data-filter');
        // use filterFn if matches value
        filterValue = filterFns[ filterValue ] || filterValue;
        $grid.isotope({ filter: filterValue });
        $('#portfolio-page .category-names a.is-checked').removeClass('is-checked');
        $( this ).addClass('is-checked');
    });

    function SetServiceContainerHeight() {
        if ($("#services-page .service-container .category-names").length != 0) {
            if (window.innerWidth > 991) {
                $("#services-page .service-container").height($("#services-page .service-container .category-content.active .main-image img").height() + 70)
            }
            else{
                $("#services-page .service-container").height($("#services-page .service-container .category-content.active .col-lg-4 .content").height() + $("#services-page .service-container .category-content.active .main-image img").height() + 70)
            }
        }
    }
    SetServiceContainerHeight()
    $(window).resize(function () { 
        SetServiceContainerHeight(true)
    });

    let image_height = $("#services-page .active .gallery-item img").outerHeight()

    $(window).resize(function () { 
        image_height = $("#services-page .active .gallery-item img").outerHeight()
    });

    function Services_Page() {
        let gallery_wrappers = document.querySelectorAll('#services-page .gallery-wrapper')
        let last_image_data_id = parseInt($("#services-page .row.active .gallery-wrapper .gallery-item").last().attr("data-id"))
        $("#services-page .row.active .gallery-wrapper .gallery-item").click(function () {
            //get clicked image src 
            let src = $(this).find("img").attr("src")

            //get main image which src is equal to clicked image src
            let main_image = $(`#services-page .row.active .main-image img[src='${src}']`)[0]

            //get gallery
            let gallery = document.querySelector('#services-page .row.active .gallery-wrapper .gallery')

            let data_id = parseInt($(this).attr("data-id"))

            if (data_id != last_image_data_id) {
                $(gallery).css("transform", `translate3d(0px, -${(data_id-1) * image_height}px, 0px)`)
            }
            if (data_id == 0) {
                $("#services-page .row.active .previous").addClass("active")
            }
            else{
                $("#services-page .row.active .previous.active").removeClass("active")
            }
            if (data_id == last_image_data_id) {
                $("#services-page .row.active .next").addClass("active")
            }
            else{
                $("#services-page .row.active .next.active").removeClass("active")
            }
            //remove active previous main image 
            $(`#services-page .row.active .main-image img.active`).removeClass("active")

            //add active class current main image
            $(main_image).addClass("active")

            //remove previous active gallery item
            $("#services-page .row.active .gallery-wrapper .gallery-item.active").removeClass("active")

            //add active class to clicked gallery item
            $(this).addClass("active")
        })

        $(gallery_wrappers).each(function () {
            $(this).height(image_height * 3)
        })
        $(window).resize(function () { 
            $(gallery_wrappers).each(function () {
                $(this).height(image_height * 3)
            })
        });
    }

    $("#services-page .category-names a").click(function (e) {
        e.preventDefault();
        let data_id = parseInt($(this).attr("data-id"))

        $("#services-page .category-names a.is-checked").removeClass("is-checked")

        $(this).addClass("is-checked")

        $("#services-page .category-content.active").removeClass("active")
        
        $(`#services-page .category-content[data-id="${data_id}"`).addClass("active")

        Services_Page()
    })
    
    $("#services-page .next").click(function(){
        $("#services-page .row.active .previous.active").removeClass("active")
        let last_image_data_id = parseInt($("#services-page .row.active .gallery-wrapper .gallery-item").last().attr("data-id"))
        let data_id = parseInt($("#services-page .row.active .gallery-wrapper .gallery-item.active").attr("data-id"))
        if (data_id < last_image_data_id - 1) {
            $('#services-page .row.active .gallery-wrapper .gallery').css("transform", `translate3d(0px, -${(data_id) * image_height}px, 0px)`)
        }
        if (data_id < last_image_data_id) {
            $("#services-page .row.active .gallery-wrapper .gallery-item.active").removeClass("active").next().addClass("active")
            $(`#services-page .row.active .main-image img.active`).removeClass("active").next().addClass("active")
        }
        if (data_id == last_image_data_id - 1) {
            $(this).addClass("active")
        }

    })
    $("#services-page .previous").click(function(){
        $("#services-page .row.active .next.active").removeClass("active")
        let data_id = parseInt($("#services-page .row.active .gallery-wrapper .gallery-item.active").attr("data-id"))

        if (data_id > 1) {
            $('#services-page .row.active .gallery-wrapper .gallery').css("transform", `translate3d(0px, -${(data_id - 2) * image_height}px, 0px)`)
        }
        if (data_id > 0) {
            $("#services-page .row.active .gallery-wrapper .gallery-item.active").removeClass("active").prev().addClass("active")
            $(`#services-page .row.active .main-image img.active`).removeClass("active").prev().addClass("active")
        }
        if (data_id == 1) {
            $(this).addClass("active")
        }
    })

    Services_Page();

    $("#get-price-offer-submit").click(function (e) {
        e.preventDefault()
        let name = $("#offer_Fullname").val();
        let number = $("#offer_PhoneNumber").val()
        let email = $("#offer_Email").val()
        let message = $("#offer_Message").val()
        if ($(this).hasClass("disabled")) {
            return;
        }
        $.ajax({
            url: "/ajax/get_price_offer",
            type: "POST",
            data: {
                "name": name,
                "number": number,
                "email": email,
                "message": message
            },
            beforeSend: function () {
                $("#get-price-offer-submit").val("Gözləyin").addClass("disabled")
            },
            success: function (res) {
                $("#get-price-offer-submit").val("Sorğu göndər").removeClass("disabled")
                if (res == "name_empty") {
                    $(".validation-div").text("Ad və Soyadınızı daxil edin").removeClass("text-success")
                    return
                }
                if (res =="name_short") {
                    $(".validation-div").text("Ad və soyad minimum 3 simvoldan ibarət olmalıdır").removeClass("text-success")
                    return
                }
                if (res == "number_empty") {
                    $(".validation-div").text("Nömrənizi daxil edin").removeClass("text-success")
                    return
                }
                if (res == "number_not_valid") {
                    $(".validation-div").text("Nömrəniz düzgün daxil edilməmişdir. Nömrəniz + 944XXXXXXXXX formatında olmalıdır").removeClass("text-success")
                    return
                }
                if (res == "email_empty") {
                    $(".validation-div").text("E-mailinizi daxil edin").removeClass("text-success")
                    return
                }
                if (res == "email_not_valid") {
                    $(".validation-div").text("E-mail düzgün daxil edilməmişdir").removeClass("text-success")
                    return
                }
                if (res == "message_empty") {
                    $(".validation-div").text("Mesajınızı yazın").removeClass("text-success")
                    return
                }
                if (res == "OK") {
                    $(".validation-div").text("Mesajınız göndərilmişdir. Ən qısa zamanda geri dönüş edəcəyimizdən əmin ola bilərisniz.").addClass("text-success")
                    return;
                }
                $(".validation-div").text("Ooops! Nə isə yanlışdır. Zəhmət olmasa yenidən cəhd edin.").removeClass("text-success")
            }
        })
    })
});