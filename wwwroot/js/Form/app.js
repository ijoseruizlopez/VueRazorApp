var _form = new Vue({
    el: '#appform',
    mixins: [_formMixinA, _formMixinB],
    data() {
        return {
            loading: true
        };
    },
    mounted() {

        setTimeout(() => {
            this.loading = false;
        }, 2000);
    }
});