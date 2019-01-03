function onfilechange(){
    abp.ui.setBusy('#app');
    var options = {
      url: "/Reconcilia/Import",
      success: function (d) {
          vm.sellOrders=d.result;
          vm.success=d.success;
          vm.wrongCount=d.result.filter(function(item){
             return item.success==false;
          }).length;
      },
      complete:function(){
          abp.ui.clearBusy('#app');
      }
    };
    $("#file-form").ajaxSubmit(options);
}

var vm = new Vue({
  el: '#app',
  data: {
     sellOrders:[],
     success:false,
     reconcilia:false,
     wrongCount:0
  },
  methods:{
     reStart:function(){
        abp.ui.setBusy('#app');
        setTimeout(function(){
            vm.reconcilia=true;
            abp.ui.clearBusy('#app');
        },2000);
     }
  }
})