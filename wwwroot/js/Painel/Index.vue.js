
var app = new Vue({
    el: "#app",
    data: {
        products: []
    },
    mounted: function(){
        var self = this;
        $.ajax({
            url: '/api/v1/products',
            method: 'GET',
            success: function (data) {
                self.products = data.data;
            },
            error: function (error) {
                console.log(error);
            }
        });
    }
})