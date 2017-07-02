function matchStart(params, data) {
    params.term = params.term || "";
    if (data.text.toUpperCase().indexOf(params.term.toUpperCase()) === 0) {
        return data;
    }

    return false;
}

$.fn.select2.amd.require(['select2/results'], function (Results) {
    var oldOption = Results.prototype.option;

    Results.prototype.option = function (data) {
        if (this.$element.is('[multiple]')) {
            if (data.real_disabled === undefined) {
                data.real_disabled = data.disabled;
            }

            data.disabled = data.real_disabled || data.selected;
        }
        return (oldOption.apply(this, [data]));
    };
});